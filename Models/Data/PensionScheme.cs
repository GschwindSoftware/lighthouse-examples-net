
namespace Gschwind.Lighthouse.Example.Models.Data {

    /// <summary>
    /// Pensionskasse
    /// </summary>
    public record PensionScheme : CompanyCapitalInsurance {

        /// <summary>
        /// Steuerbegünstigung von Beiträgen zur bAV
        /// </summary>
        public InsuranceTaxType InsuranceTaxType {
            get;
            init;
        } = InsuranceTaxType.Allowance;
    }

}
