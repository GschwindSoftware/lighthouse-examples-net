namespace Gschwind.Lighthouse.Example.Models.Data;

/// <summary>
/// Vorgang Lebensversicherung
/// </summary>
public record FundLinkedInsurance : PrivateCapitalInsurance {

    /// <summary>
    /// Rentenfaktor
    /// </summary>
    public double PensionFactor {
        get;
        set;
    }

    /// <summary>
    /// Liste der Fonds
    /// </summary>
    public ICollection<FundSecurity> Funds {
        get;
        set;
    } = new List<FundSecurity>();

}
