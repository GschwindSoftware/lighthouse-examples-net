
namespace Gschwind.Lighthouse.Example.Models.Plans.Settings {

    /// <summary>
    /// Stellt die Daten eines Finanzplans bereit
    /// </summary>
    public record PlanSettings {

        /// <summary>
        /// Allgemeine Einstellungen
        /// </summary>
        public SettingsGeneral? General {
            get;
            init;
        }

        /// <summary>
        /// Nachfolgeeinstellungen
        /// </summary>
        public SettingsEstate? Estate {
            get;
            init;
        }

        /// <summary>
        /// Währungseinstellungen
        /// </summary>
        public SettingsCurrency? Currency {
            get;
            init;
        }
    }

}
