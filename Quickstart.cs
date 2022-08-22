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
    readonly ILogger<Quickstart> _logger;

    public Quickstart(LighthouseApi api, TestPlan testPlan, ILogger<Quickstart> logger) =>
        (_api, _testPlan, _logger) = (api, testPlan, logger);

    #endregion

    #region Beispiele

    internal async Task RunAsync() {
        // Möglichkeiten einen Finanzplan zu laden:

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
