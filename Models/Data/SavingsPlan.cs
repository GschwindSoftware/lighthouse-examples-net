namespace Gschwind.Lighthouse.Example.Models.Data;

/// <summary>
/// Sparplan
/// </summary>
public record SavingsPlan : SavingDeposit {

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

    /// <summary>
    /// Bonus
    /// </summary>
    public ICollection<PercentValue> Bonus {
        get;
        init;
    } = new List<PercentValue>();

}
