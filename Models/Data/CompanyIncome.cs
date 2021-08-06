
namespace Gschwind.Lighthouse.Example.Models.Data {

    /// <summary>
    /// Untervorgang Betriebseinnahme
    /// </summary>
    public record CompanyIncome : CashflowSubFinance {

        /// <summary>
        /// Typ der Einnahmen
        /// </summary>
        public CompanyIncomeType CompanyIncomeType {
            get;
            init;
        }

    }

}