namespace Gschwind.Lighthouse.Example.Models.Data;

/// <summary>
/// Werbungskosten
/// </summary>
public record AdvertisingCosts : CashFlowBase {

    /// <summary>
    /// Einkunftsart
    /// </summary>
    public TaxableExpenseType TaxableExpenseType {
        get;
        init;
    } = TaxableExpenseType.None;

}
