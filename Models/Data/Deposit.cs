namespace Gschwind.Lighthouse.Example.Models.Data;

/// <summary>
/// Depot
/// </summary>
public record Deposit : SecurityInvestment {

    /// <summary>
    /// Liste der Wertpapiere
    /// </summary>
    public ICollection<Security> Securities {
        get;
        init;
    } = new List<Security>();

}
