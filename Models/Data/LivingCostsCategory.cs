using System;

namespace Gschwind.Lighthouse.Example.Models.Data {

    /// <summary>
    /// Lebenshaltungskostenkategorie
    /// </summary>
    public record LivingCostsCategory {

        /// <summary>
        /// Kategorie
        /// </summary>
        public LivingCostsType Category {
            get;
            init;
        }

        /// <summary>
        /// Beschreibung
        /// </summary>
        public bool AutomaticCalculation {
            get;
            init;
        } = true;

        /// <summary>
        /// Monatlicher Betrag
        /// </summary>
        public double MonthlyValue {
            get;
            init;
        }

    }

}