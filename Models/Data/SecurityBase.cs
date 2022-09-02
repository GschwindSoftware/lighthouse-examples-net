namespace Gschwind.Lighthouse.Example.Models.Data;

/// <summary>
/// Wertpapierbasis
/// </summary>
public abstract record SecurityBase : PlanData {

    /// <summary>
    /// Verkauf
    /// </summary>
    public Selling Selling {
        get;
        init;
    } = new();

}
