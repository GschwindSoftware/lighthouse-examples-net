namespace Gschwind.Lighthouse.Example.Models.Data;

/// <summary>
/// Stammdaten für geschlossene Fonds
/// </summary>
public record FundSecurity : SecurityBase {

    /// <summary>
    /// Ausschüttungen
    /// </summary>
    public ICollection<PercentValue> Dividends {
        get;
        set;
    } = [];

    /// <summary>
    /// Wertsteigerungen
    /// </summary>
    public ICollection<PercentValue> Appreciations {
        get;
        set;
    } = [];

    /// <summary>
    /// Muss Wertsteigerung und Dividende versteuert werden?
    /// </summary>
    public bool IsTaxable {
        get;
        set;
    } = true;

    /// <summary>
    /// Wiederanlage der Gewinne
    /// </summary>
    public bool ReinvestDividends {
        get;
        set;
    } = true;

    /// <summary>
    /// Agio beim Kauf
    /// </summary>
    public double Agio {
        get;
        set;
    }

    /// <summary>
    /// Fälligkeitsdatum
    /// </summary>
    public DateTime MaturityDate {
        get;
        set;
    } = DateTime.Now.EndOfYear().AddYears(10);

    /// <summary>
    /// Dividendenausschüttung
    /// </summary>
    public DateTime DividendPayout {
        get;
        set;
    } = DateTime.Now.EndOfYear();

    /// <summary>
    /// Anteil am Kapitalbeitrag
    /// </summary>
    public double Share {
        get;
        set;
    }

}
