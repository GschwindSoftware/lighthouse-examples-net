namespace Gschwind.Lighthouse.Example.Models.Data;

/// <summary>
/// Spareinlage
/// </summary>
public abstract record SavingDeposit : CashValue {

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
