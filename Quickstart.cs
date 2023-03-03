// Copyright 2023 🔵🔵🔴🔵 Gschwind Software GmbH All rights reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE file.

using ConsoleTables;
using Gschwind.Lighthouse.Example.Api;
using Gschwind.Lighthouse.Example.Models;
using Gschwind.Lighthouse.Example.Models.Crm;
using Gschwind.Lighthouse.Example.Models.Data;
using Gschwind.Lighthouse.Example.Models.Family;
using Gschwind.Lighthouse.Example.Models.Report;
using Gschwind.Lighthouse.Example.Models.Reports;
using Microsoft.Extensions.Logging;
using Refit;

namespace Gschwind.Lighthouse.Example;

/// <summary>
/// Beispielanwendung für die Nutzung des Financial Lighthouse Rechenkerns
/// </summary>
internal class Quickstart {

    #region Abhängigkeiten

    readonly LighthouseApi _api;
    readonly TestPlan _testPlan;
    readonly ExternalClientDataProvider _clients;
    readonly ILogger<Quickstart> _logger;

    public Quickstart(
        LighthouseApi api,
        TestPlan testPlan,
        ExternalClientDataProvider clients,
        ILogger<Quickstart> logger
    ) =>
        (_api, _testPlan, _clients, _logger) = (api, testPlan, clients, logger);

    #endregion

    #region Beispiele

    internal async Task RunAsync() {
        await GenerateReport();
        await SynchronizeStatusQuo();
        await UpdateStatusQuoFamily("654321");
    }

    /// <summary>
    /// 💡 Beispiel: Laden eines Plans und Erzeugung einer Auswertung
    /// </summary>
    /// <remarks>
    /// In diesem Beispiel werden die Möglichkeiten demonstiert, einen <see cref="Models.Plans.Plan">Finanzplan</see>
    /// eines Kunden zu laden. Sie können hierzu einen vorhandenen, in der Kundenmappe abgespeicherten
    /// Plan nutzen oder die gesamten Plandaten ad hoc generieren.
    ///
    /// Der Finanzplan dient als Datengrundlage zur Erzeugung von <see cref="Report">Auswertungen</see>.
    /// Hierbei erhalten Sie die Zeitreihe mit den Auswertedaten und dazugehörige Metadaten der Auswertung zurück.
    /// </remarks>
    async Task GenerateReport() {
        // Über die API abrufen
        var plan = await _testPlan.FromApiAsync(1);
        // Oder aus Datei laden
        plan ??= await _testPlan.FromJsonAsync("plan.json");
        // Oder programmatisch erzeugen
        plan ??= _testPlan.Programmatically();

        // Eine Auswertung - hier z.B. Versorgungslücke - erzeugen
        var response = await _api.Reports.GenerateRetirementGapReportAsync(new(plan), RetirementReportType.SupplyGap);
        await response.EnsureSuccessStatusCodeAsync();
        PrintReport(response.Content ?? throw new InvalidDataException());
    }

    /// <summary>
    /// 💡 Beispiel: Einen Status Quo aktualisieren.
    /// </summary>
    /// <remarks>
    /// Hier wird die Vorgehensweise illustriert, um den Status Quo eines Kunden zu aktualisieren. Der Status Quo
    /// ist ein spezieller <see cref="Models.Plans.Plan">Finanzplan</see>, der die aktuelle Situation eines Kunden
    /// wie in der Kundenmappe der Oberfläche dargestellt festhält.
    ///
    /// Teil eines Finanzplans sind <see cref="Models.Data.PlanData">Vorgänge</see>, mit denen Berater die
    /// Finanzsituation des Kunden erfassen (Einkünfte, Ausgaben, Vermögenswerte usw.).
    ///
    /// In diesem Beispiel wird davon ausgegangen, dass die Werpapierdepots von Kunden und deren Inhalte in einem
    /// Zweitsystem vorliegen und mit Financial Lighthouse synchronisiert werden sollen.
    /// </remarks>
    async Task SynchronizeStatusQuo() {
        // Wertpapierdepotdaten aus einem externen System
        var externalClientData = await _clients.GetPortfoliosAsync() ?? throw new InvalidDataException();

        // Kontakte in Financial Lighthouse, die eine Kundennummer besitzen
        var resp = await _api.Crm.QueryContactsAsync(new() {
            Filter =
                Term.Ne<Contact>(c => c.ClientNumber, null) &
                Term.Ne<Contact>(c => c.ClientNumber, String.Empty)
        });
        await resp.EnsureSuccessStatusCodeAsync();

        var clientNumbersInLighthouse = resp
            .Content?
            .Select(c => c.ClientNumber!)
            .ToHashSet()
            ?? new();

        // Update des Status Quo jeder dieser Kunden
        foreach (var clientNumber in clientNumbersInLighthouse)
            try {
                await UpdateClientStatusQuo(clientNumber, externalClientData);
            } catch (Exception e) {
                _logger.LogError(e, "Fehler beim Update des Status Quos");
            }
    }

    /// <seealso cref="SynchronizeStatusQuo"/>
    async Task UpdateClientStatusQuo(string clientNumber, IEnumerable<ExternalClientPortfolio> externalClientData) {
        // Im externen System bekannte Wertpapierdepots
        var externalSecurityAccounts = externalClientData
            .Where(c => String.Equals(c.ClientId, clientNumber))
            .SelectMany(c => c.Accounts)
            .ToArray();

        if (!externalSecurityAccounts.Any())
            return;

        // Vorgänge des Status Quo des Kunden abfragen. Korrelation über die Kundennummer
        var respGet = await _api.Plans.GetStatusQuoDataAsync(clientNumber);
        await respGet.EnsureSuccessStatusCodeAsync();
        var data = (respGet.Content ?? throw new InvalidDataException()).ToList();

        // Vorgänge für Wertpapierdepots um externe Daten ergänzen
        EnrichSecurityAccount(data, externalSecurityAccounts);

        // Status Quo aktualisieren
        var respUpdate = await _api.Plans.UpdateStatusQuoDataAsync(clientNumber, data);
        if (!respUpdate.IsSuccessStatusCode)
            throw new HttpRequestException();
    }

    /// <seealso cref="SynchronizeStatusQuo"/>
    void EnrichSecurityAccount(List<PlanData> data, IEnumerable<ExternalSecuritiesAccount> externalSecurityAccounts) {
        foreach (var account in externalSecurityAccounts) {
            // Die vor Nutzern versteckte ImportId kann verwendet werden, um eine Korrelation zwischen dem Vorgang
            // und dem Datensatz im externen Datensatz herzustellen. Hier wird die Depotnummer als Schlüssel genutzt
            var entry = data
                .OfType<Deposit>()
                .SingleOrDefault(d => account.AccountNumber.Equals(d.ImportId));

            if (entry != null)
                // Zuvor bereits importiert
                data.Remove(entry);
            else
                // Bisher unbekannt
                entry = new() {
                    ImportId = account.AccountNumber,
                    Name = $"Depot {account.AccountNumber}"
                };

            // Wertpapiere auf Grundlage des externen Datenbestands aktualisieren.
            // Die Korrelation findet anhand der ISIN statt
            entry = entry with {
                Securities = account
                    .Securities
                    .GroupJoin(
                        entry.Securities.DefaultIfEmpty(),
                        s => s.Isin,
                        s => s?.Isin,
                        (external, matches) => {
                            var existing = matches.FirstOrDefault();

                            existing ??= new Security {
                                Name = "Wertpapier",
                                Isin = external.Isin,
                                Quantity = external.Quantity,
                                Quote = external.Quote
                            };

                            return existing with {
                                Quantity = external.Quantity,
                                Quote = external.Quote,
                                Informations = existing.Informations with {
                                    LastChanged = DateTime.Now,
                                    LastUser = String.Empty
                                }
                            };
                        }
                    )
                    .ToList()
            };

            data.Add(entry);
        }
    }

    /// <summary>
    /// 💡 Beispiel: Familienstammbaum im Status Quo aktualisieren.
    /// </summary>
    /// <remarks>
    /// Demonstriert das Speichern eines Stammbaums im Status Quo. Es werden die Angaben aus den Kontaktdaten herangezogen, um
    /// einen Stammbaum in der Kundenmappe (Status Quo) zu konstruieren.
    /// </remarks>
    /// <seealso cref="SynchronizeStatusQuo"/>
    async Task UpdateStatusQuoFamily(string clientNumber) {
        var respQuery = await _api.Crm.QueryContactsAsync(new Query{
            Filter = Term.Eq<Contact>(c => c.ClientNumber, clientNumber)
        });

        await respQuery.EnsureSuccessStatusCodeAsync();

        if (respQuery.Content is { Count: 1 } matches && matches.Single() is Person p) {
            var client = new Client {
                Title = p.Title,
                FirstName = p.FirstName,
                LastName = p.LastName,
                IsMarried = true,
                Gender = p.Gender switch {
                    Models.Crm.Gender.Male => Models.Family.Gender.Male,
                    _ => Models.Family.Gender.Female
                },
            };

            if (p.Birthday != null)
                client = client with { Birthday = p.Birthday.Value };

            var partner = new Partner {
                FirstName = "Partner",
                LastName = p.LastName,
                Gender = p.Gender switch {
                    Models.Crm.Gender.Male => Models.Family.Gender.Female,
                    _ => Models.Family.Gender.Male
                },
            };

            var child = new Child {
                FirstName = "Kind",
                LastName = p.LastName
            };

            var father = new Relative {
                FirstName = "Vater",
                IsDead = true,
                LastName = p.LastName
            };

            var stepmother = new Relative {
                FirstName = "Mutter",
                LastName = p.LastName
            };

            /*
                ☠ --- 👵 Eltern
                |
                👨 -+- 👩 Kunde / Partner
                    |
                   👶     Kinder
            */

            var family = new Family {
                Members = { client, partner, child, father, stepmother },
                Relationships = {
                    client.IsPartnerOf(partner),
                    child.IsChildOf(client),
                    child.IsChildOf(partner),
                    client.IsChildOf(father),
                    father.IsPartnerOf(stepmother)
                }
            };

            try {
                var respUpdate = await _api.Plans.UpdateStatusQuoFamilyAsync(clientNumber, family);
                await respUpdate.EnsureSuccessStatusCodeAsync();
            } catch (ApiException e) {
                var problem = e.GetContentAsAsync<ProblemDetails>();
                _logger.LogError(e, "Fehler bei der Aktualisierung des Stammbaums {problem}", problem);
            }
        }
    }

    #endregion

    #region Ausgabe

    void PrintReport(Report report) {
        var columns = new[] { "" }
            .Concat(report.Categories.Select(c => c.ToString()))
            .ToArray();

        var table = new ConsoleTable(columns);
        GenerateTable(report.Series, 0, ref table);

        _logger.LogInformation(table.ToString());
        File.AppendAllText("out.txt", table.ToString() + "\n\n");
    }

    void GenerateTable(IEnumerable<HierarchicalDataSeries> series, int level, ref ConsoleTable table) {
        var indent = new string(' ', level * 2);

        IEnumerable<object> cells(HierarchicalDataSeries s) {
            yield return $"{indent}{s.Title}";
            foreach (var d in s.Data)
                yield return $"{indent}{d:0.##}";
        }

        foreach (var s in series) {
            table.AddRow(cells(s).ToArray());
            GenerateTable(s.Series, level + 1, ref table);
        }
    }

    #endregion

}
