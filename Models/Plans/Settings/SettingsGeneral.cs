using System;

namespace Gschwind.Lighthouse.Example.Models.Plans.Settings {

    /// <summary>
    /// Allgmeine Einstellungen für einen Finanzplan
    /// </summary>
    public record SettingsGeneral {

        /// <summary>
        /// Plantyp
        /// </summary>
        public PlanType PlanType {
            get;
            init;
        }

        /// <summary>
        /// Die Beschreibung
        /// </summary>
        public string? Description {
            get;
            init;
        }

        /// <summary>
        /// Das Planungsdatum
        /// </summary>
        public DateTime PlanningDate {
            get;
            init;
        }

        /// <summary>
        /// Sind Namen und Geburtsdaten verschlüsselt
        /// </summary>
        public bool UseEncryption {
            get;
            init;
        }

        /// <summary>
        /// Auswertestart
        /// </summary>
        public int StartYear {
            get;
            init;
        }

        /// <summary>
        /// Auswertedauer
        /// </summary>
        public int Duration {
            get;
            init;
        }

        /// <summary>
        /// Schreibgeschützt
        /// </summary>
        public bool Locked {
            get;
            init;
        }

    }

}
