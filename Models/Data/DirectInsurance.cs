namespace Gschwind.Lighthouse.Example.Models.Data;

/// <summary>
/// Direktversicherung
/// </summary>
public record DirectInsurance : CompanyCapitalInsurance {

    /// <summary>
    /// Steuerbegünstigung von Beiträgen zur betrireblichen Altersvorsorge
    /// </summary>
    public InsuranceTaxType InsuranceTaxType {
        get;
        init;
    } = InsuranceTaxType.Allowance;

}
