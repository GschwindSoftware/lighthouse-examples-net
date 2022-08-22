namespace Gschwind.Lighthouse.Example.Models.Data;

/// <summary>
/// Spende
/// </summary>
public record Donation : CashFlowBase {

    /// <summary>
    /// Steuerliche Begünstigung
    /// </summary>
    public MembershipTaxAdvantage MembershipTaxAdvantage {
        get;
        init;
    } = MembershipTaxAdvantage.None;

    /// <summary>
    /// Monat der Zahlung
    /// </summary>
    public int PaymentMonth {
        get;
        init;
    } = 12;

    /// <summary>
    /// Zahlung bei Erwerbsunfähigkeit
    /// </summary>
    public bool DisabilityPayment {
        get;
        init;
    }

}
