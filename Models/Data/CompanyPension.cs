namespace Gschwind.Lighthouse.Example.Models.Data {

    /// <summary>
    /// Betriebliche Altersvorsorge
    /// </summary>
    public abstract record CompanyPension : EndowmentInsurance {

        /// <summary>
        /// Zahlung der Beiträge zu einer betrieblichen Altersvorsorge
        /// </summary>
        public PremiumPayment PremiumPayment {
            get;
            init;
        } = PremiumPayment.Employee;

        /// <summary>
        /// Art der Leistungsauszahlung (einmalige Kapitalleistung oder monatliche Rente)
        /// </summary>
        public InsurancePayoutType InsurancePayoutType {
            get;
            init;
        } = InsurancePayoutType.MonthlyPension;

        /// <summary>
        /// Kapitalleistung
        /// </summary>
        public double CapitalPayment {
            get;
            init;
        }

    }

}
