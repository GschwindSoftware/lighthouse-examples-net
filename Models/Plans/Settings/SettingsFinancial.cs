namespace Gschwind.Lighthouse.Example.Models.Plans.Settings {

    /// <summary>
    /// Einstellungen für die Finanzplanung
    /// </summary>
    public record SettingsFinancial {

        /// <summary>
        /// Das Bundesland der Planung
        /// </summary>
        public FederalState FederalState {
            get;
            init;
        }

        /// <summary>
        /// Steigerung der Beitragsbemessungsgrenzen für Sozialabgaben
        /// </summary>
        public double SocialContributionsIncrease {
            get;
            init;
        }

        /// <summary>
        /// Rentenanpassung
        /// </summary>
        public double PensionIncrease {
            get;
            init;
        }

        /// <summary>
        /// Parameter für die Erwerbsunfähigkeit
        /// </summary>
        public DisabilitySettings DisabilitySettings {
            get;
            init;
        } = new DisabilitySettings();


        /// <summary>
        /// Anzeige der Szenarien
        /// </summary>
        public bool ShowScenarios {
            get;
            init;
        } = true;

    }

}
