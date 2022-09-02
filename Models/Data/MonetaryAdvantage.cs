namespace Gschwind.Lighthouse.Example.Models.Data;

/// <summary>
/// Geldwerter Vorteil
/// </summary>
public record MonetaryAdvantage : PlanData {

    /// <summary>
    /// Bonuszahlungen
    /// </summary>
    public CashFlows CashFlows {
        get;
        init;
    } = new() { Period = Period.Yearly };

    /// <summary>
    /// Monat der Zahlung
    /// </summary>
    public int PaymentMonth {
        get;
        init;
    } = 12;

}
