using System;

namespace Gschwind.Lighthouse.Example.Models.Plans.Settings {

    /// <summary>
    /// Einstellungen für die Finanzplanung
    /// </summary>
    public record DisabilitySettings {

        /// <summary>
        /// Datum der Krankheit
        /// </summary>
        public DateTime Date {
            get;
            init;
        } = new(DateTime.Now.Year + 1, 1, 1);

        /// <summary>
        /// Dauer der Krankheit bis Erwerbsunfähigkeit
        /// </summary>
        public int IllnessWeeks {
            get;
            init;
        } = 78;

        /// <summary>
        /// Verursacht durch Unfall
        /// </summary>
        public bool DueToAccident {
            get;
            init;
        }

        /// <summary>
        /// Invalidität
        /// </summary>
        public double DisabilityRate {
            get;
            init;
        } = 60;
    }

}
