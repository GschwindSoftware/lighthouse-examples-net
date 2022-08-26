// Copyright 2021 🔵🔵🔴🔵 Gschwind Software GmbH All rights reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE file.

using ConsoleTables;
using Gschwind.Lighthouse.Example.Api;
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
        PrintReport(response.EnsureSuccess());
    }

    /// <summary>
    /// 💡 Beispiel: Einen Status Quo aktualisieren.
    /// </summary>
    /// <remarks>
    /// Hier wird die Vorgehensweise illustriert, um den Status Quo eines Kunden zu aksutalisieren. Der Status Quo
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
        var externalData = await _clients.GetProtfoliosAsync() ?? throw new ApplicationException();
        await Task.CompletedTask;
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
