namespace Gschwind.Lighthouse.Example.Models.Data;

/// <summary>
/// Wertpapier
/// </summary>
public record Security : SecurityBase {

    /// <summary>
    /// Ausschüttungen
    /// </summary>
    public ICollection<PercentValue> Dividends {
        get;
        init;
    } = [];

    /// <summary>
    /// Wertsteigerungen
    /// </summary>
    public ICollection<PercentValue> Appreciations {
        get;
        init;
    } = [];

    /// <summary>
    /// Muss Wertsteigerung und Dividende versteuert werden?
    /// </summary>
    public bool IsTaxable {
        get;
        init;
    } = true;

    /// <summary>
    /// Wiederanlage der Gewinne
    /// </summary>
    public bool ReinvestDividends {
        get;
        init;
    }

    /// <summary>
    /// Agio beim Kauf
    /// </summary>
    public double Agio {
        get;
        init;
    }

    /// <summary>
    /// Fälligkeitsdatum
    /// </summary>
    public DateTime MaturityDate {
        get;
        init;
    } = DateTime.Now.EndOfYear().AddYears(10);

    /// <summary>
    /// Dividendenausschüttung
    /// </summary>
    public DateTime DividendPayout {
        get;
        init;
    } = DateTime.Now.EndOfYear();

    /// <summary>
    /// Einzahlungen
    /// </summary>
    public CashFlows Savings {
        get;
        init;
    } = new() { Period = Period.Yearly };

    /// <summary>
    /// Sondereinzahlungen
    /// </summary>
    public ICollection<DateValue> AdditionalSavings {
        get;
        init;
    } = [];

}
