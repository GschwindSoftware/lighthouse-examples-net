namespace Gschwind.Lighthouse.Example.Models.Data;

/// <summary>
/// Stammdaten für geschlossene Fonds
/// </summary>
public record FundsDataTable {

    /// <summary>
    /// Einzahlungen in % der Beteiligungssumme
    /// </summary>
    public ICollection<PercentValue> Payments {
        get;
        init;
    } = [];

    /// <summary>
    /// Ausschüttungen in % der Beteiligungssumme
    /// </summary>
    public ICollection<PercentValue> Distriubtions {
        get;
        init;
    } = [];

    /// <summary>
    /// Besteuerung in % der Beteiligungssumme
    /// </summary>
    public ICollection<PercentValue> Taxable {
        get;
        init;
    } = [];

    /// <summary>
    /// Verkäufe in % der Beteiligungssumme
    /// </summary>
    public ICollection<PercentValue> Sales {
        get;
        init;
    } = [];

    /// <summary>
    /// Besteuerung des Verkäufe in % der Beteiligungssumme
    /// </summary>
    public ICollection<PercentValue> TaxableSales {
        get;
        init;
    } = [];

    /// <summary>
    /// Marktwert in % der Beteiligungssumme
    /// </summary>
    public ICollection<PercentValue> MarketValues {
        get;
        init;
    } = [];

}
