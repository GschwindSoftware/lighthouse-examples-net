namespace Gschwind.Lighthouse.Example.Models.Data;

/// <summary>
/// Bildet den Vorgang einer Kfz-Versicherung ab
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
