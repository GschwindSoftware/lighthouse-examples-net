using Gschwind.Lighthouse.Example.Serialization;

namespace Gschwind.Lighthouse.Example.Models.Data;

/// <summary>
/// Wertpapierdepot
/// </summary>
[SchemaId("Deposit")]
public record SecuritiesAccount : Deposit {

    /// <summary>
    /// Liste der Wertpapiere
    /// </summary>
    public ICollection<Security> Securities {
        get;
        init;
    } = new List<Security>();

    /// <summary>
    /// Verkauf
    /// </summary>
    public Selling Selling {
        get;
        init;
    } = new();

}
