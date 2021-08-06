using System;

namespace Gschwind.Lighthouse.Example.Models.Data {

    /// <summary>
    /// Erbbau-Bewertung
    /// </summary>
    public record LeaseholdValuation {

        /// <summary>
        /// Gesamtlaufzeit Erbbau
        /// </summary>
        public int TotalDuration {
            get;
            init;
        } = 99;

        /// <summary>
        /// Jährlicher Erbbauzins
        /// </summary>
        public double GroundRent {
            get;
            init;
        }

        /// <summary>
        /// Entschädigung in %
        /// </summary>
        public double Compensation {
            get;
            init;
        } = 100;

    }

}