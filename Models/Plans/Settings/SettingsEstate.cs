namespace Gschwind.Lighthouse.Example.Models.Plans.Settings {

    /// <summary>
    /// Einstellungen für die Nachfolgeplanung
    /// </summary>
    public record SettingsEstate {

        /// <summary>
        /// Todeszeitpunkt
        /// </summary>
        public DateTime TimeOfDeath {
            get;
            init;
        }

        /// <summary>
        /// Erbfolge
        /// </summary>
        public Succession Succession {
            get;
            init;
        }

        /// <summary>
        /// Güterstand
        /// </summary>
        public MatrimonialRegime MatrimonialRegime {
            get;
            init;
        }

        /// <summary>
        /// Datum der Eheschließung
        /// </summary>
        public DateTime Wedding {
            get;
            init;
        }

        /// <summary>
        /// Anfangsvermögen Kunde
        /// </summary>
        public double InitialAssetClient {
            get;
            init;
        }

        /// <summary>
        /// Anfangsvermögen Partner
        /// </summary>
        public double InitialAssetPartner {
            get;
            init;
        }

        /// <summary>
        /// Liquidiätsüberschuss berücksichtigen
        /// </summary>
        public bool IncludeCumulatedLiquidity {
            get;
            init;
        } = true;

        /// <summary>
        /// Testament
        /// </summary>
        public Testament Testament {
            get;
            init;
        } = new();

    }

}
