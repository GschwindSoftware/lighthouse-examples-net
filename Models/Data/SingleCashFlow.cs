namespace Gschwind.Lighthouse.Example.Models.Data;

/// <summary>
/// Einzelner Cashflow
/// </summary>
public abstract record SingleCashFlow : PlanData {

    /// <summary>
    /// Datum
    /// </summary>
    public DateTime Date {
        get;
        init;
    } = new(DateTime.Now.Year, 1, 1);

    /// <summary>
    /// Betrag
    /// </summary>
    public double Value {
        get;
        init;
    }

}
