namespace Gschwind.Lighthouse.Example.Models.Data;

/// <summary>
/// Kfz-Versicherung
/// </summary>
public record CarInsurance : PropertyInsurance {

    /// <summary>
    /// Beiträge zur Kaskoversicherung
    /// </summary>
    public CashFlows HullPremium {
        get;
        init;
    } = new();

}
