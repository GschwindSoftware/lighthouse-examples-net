using System;

namespace Gschwind.Lighthouse.Example.Models.Data {

    /// <summary>
    /// Basisklasse für Kapitalgesellschaften
    /// </summary>
    public record CapitalCompany : CompanyBase {

        /// <summary>
        /// Ausschüttungen
        /// </summary>
        public CashFlows Payouts {
            get;
            init;
        } = new CashFlows { Period = Period.Yearly };

        /// <summary>
        /// Gesellschaftsform
        /// </summary>
        public CapitalCompanyType CapitalCompanyType {
            get;
            init;
        } = CapitalCompanyType.GmbH;

        /// <summary>
        /// Wird das Teileinkünfteverfahren angewandt?
        /// </summary>
        public bool IsPartialIncomeMethod {
            get;
            init;
        }

        /// <summary>
        /// Versteuerung des Verkaufs
        /// </summary>
        public Taxation SaleTaxation {
            get;
            init;
        }

    }

}
