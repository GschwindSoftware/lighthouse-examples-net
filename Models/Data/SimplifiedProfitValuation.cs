using System;

namespace Gschwind.Lighthouse.Example.Models.Data {

    /// <summary>
    /// Vereinfachtes Ertragswertverfahren
    /// </summary>
    public record SimplifiedProfitValuation {

        /// <summary>
        /// Betriebsergebnis Jahr 1
        /// </summary>
        public double OperatingResult1 {
            get;
            init;
        }

        /// <summary>
        /// Betriebsergebnis Jahr 2
        /// </summary>
        public double OperatingResult2 {
            get;
            init;
        }

        /// <summary>
        /// Betriebsergebnis Jahr 3
        /// </summary>
        public double OperatingResult3 {
            get;
            init;
        }

        /// <summary>
        /// Vermögenswert
        /// </summary>
        public double AssetValue {
            get;
            init;
        }

    }

}