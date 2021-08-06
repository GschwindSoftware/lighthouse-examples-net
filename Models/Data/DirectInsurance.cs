
namespace Gschwind.Lighthouse.Example.Models.Data {

    /// <summary>
    /// Direktversicherung
    /// </summary>
    public record DirectInsurance : CompanyCapitalInsurance {

        /// <summary>
        /// Steuerbegünstigung von Beiträgen zur bAV
        /// </summary>
        public InsuranceTaxType InsuranceTaxType {
            get;
            init;
        } = InsuranceTaxType.Allowance;
    }

}
