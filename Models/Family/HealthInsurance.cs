namespace Gschwind.Lighthouse.Example.Models.Family {

    /// <summary>
    /// Angaben zur Krankenkasse der Person
    /// </summary>
    public record HealthInsurance {

        /// <summary>
        /// Der Name der Krankenkasse
        /// </summary>
        public string InsuranceCompany {
            get;
            init;
        } = String.Empty;

        /// <summary>
        /// Der Zusatzbeitrag
        /// </summary>
        public double AdditionalRate {
            get;
            init;
        } = 0.9;

        /// <summary>
        /// Gibt an, ob eine Krankentagegeld-Versicherung besteht
        /// </summary>
        public bool HasDailyBenefitsInsurance {
            get;
            init;
        } = true;

    }

}
