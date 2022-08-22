namespace Gschwind.Lighthouse.Example.Models.Data {

    /// <summary>
    /// Private Krankenversicherung
    /// </summary>
    public record PrivateHealthInsurance : PrivateSocialInsurance {

        /// <summary>
        /// Beitragszuschuss im Ruhestand
        /// </summary>
        public GrantPensionType GrantPensionType {
            get;
            init;
        } = GrantPensionType.None;

        /// <summary>
        /// Ist es gleichzeitig eine Pflegeversicherung?
        /// </summary>
        public bool IsNursingCareInsurance {
            get;
            init;
        } = true;

        /// <summary>
        /// Krankentagegeld
        /// </summary>
        public double DailySicknessAllowance {
            get;
            init;
        }

        /// <summary>
        /// Krankentagegeldzahlung nach x Wochen
        /// </summary>
        public int PaymentAfterWeeks {
            get;
            init;
        } = 7;

        /// <summary>
        /// Beitragsbefreiung im Krankheitsfall
        /// </summary>
        public bool PremiumContribution {
            get;
            init;
        }

    }

}
