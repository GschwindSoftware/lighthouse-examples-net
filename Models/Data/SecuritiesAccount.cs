using Gschwind.Lighthouse.Example.Serialization;

namespace Gschwind.Lighthouse.Example.Models.Data;

/// <summary>
/// Wertpapierdepot
/// </summary>
[SchemaId("Deposit")]
public record SecuritiesAccount : SecurityInvestment {

    /// <summary>
    /// Liste der Wertpapiere
    /// </summary>
    public ICollection<Security> Securities {
        get;
        init;
    } = [];

}
