using Gschwind.Lighthouse.Example.Models.Plans.Settings;

namespace Gschwind.Lighthouse.Example.Models.Reports;

/// <summary>
/// Beschreibt zusammenhängende Datenpunkte von Reihen innerhalb eines Berichtes
/// </summary>
public record ReportCategory {

    /// <summary>
    /// Der `ReportCategoryType` der Kategorie
    /// </summary>
    public ReportCategoryType Type {
        get;
        private set;
    } = default;

    /// <summary>
    /// Der Startzeitpunkt der Kategorie für `ReportCategoryType.Date` oder `ReportCategoryType.Range`
    /// </summary>
    public DateTime? Start {
        get;
        private set;
    } = default;

    /// <summary>
    /// Der Endzeitpunkt der Kategorie für `ReportCategoryType.Range`
    /// </summary>
    public DateTime? End {
        get;
        private set;
    } = default;

    /// <summary>
    /// Der Name der Eigenschaft der Kategorie für `ReportCategoryType.DataMember`
    /// </summary>
    public string? DataMember {
        get;
        private set;
    } = default;

    /// <summary>
    /// Der Begünstige
    /// </summary>
    public Heritage? Beneficiary {
        get;
        private set;
    } = default;

    /// <inheritdoc/>
    public override string? ToString() =>
        Type switch {
            ReportCategoryType.DataMember => DataMember,
            ReportCategoryType.Date => Start?.ToShortDateString(),
            ReportCategoryType.Range => $"{Start?.ToShortDateString()} - {End?.ToShortDateString()}",
            ReportCategoryType.Heritage => Beneficiary?.PersonName,
            _ => base.ToString()
        };

}
