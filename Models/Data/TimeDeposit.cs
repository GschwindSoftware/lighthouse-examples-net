namespace Gschwind.Lighthouse.Example.Models.Data;

/// <summary>
/// Vorgang Termineinlage
/// </summary>
public abstract record TimeDeposit : CashValue {

    /// <summary>
    /// Fälligkeit
    /// </summary>
    public DateTime Maturity {
        get;
        init;
    } = new(DateTime.Now.Year + 4, 12, 31);

    /// <summary>
    /// Wiederanlage nach Fälligkeit
    /// </summary>
    public bool DoReinvest {
        get;
        init;
    } = true;

}
