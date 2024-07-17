namespace Gschwind.Lighthouse.Example.Models.Data;

/// <summary>
/// Fondsgebundene Versicherung
/// </summary>
public record FundLinkedInsurance : PrivateCapitalInsurance {

    /// <summary>
    /// Rentenfaktor
    /// </summary>
    public double PensionFactor {
        get;
        init;
    }

    /// <summary>
    /// Liste der Fonds
    /// </summary>
    public ICollection<FundSecurity> Funds {
        get;
        init;
    } = [];

}
