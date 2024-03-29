namespace Gschwind.Lighthouse.Example.Models.Data;

/// <summary>
/// Cashflow-Untervorgang
/// </summary>
public abstract record CashflowSubFinance : PlanData {

    /// <summary>
    /// Zahlungen
    /// </summary>
    public CashFlows CashFlows {
        get;
        init;
    } = new();

    /// <summary>
    /// Ende der Zahlungen
    /// </summary>
    public Moment Termination {
        get;
        init;
    } = new();

}
