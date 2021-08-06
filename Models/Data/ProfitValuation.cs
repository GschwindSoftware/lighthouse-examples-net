using System;

namespace Gschwind.Lighthouse.Example.Models.Data {

    /// <summary>
    /// Sachwertverfahren
    /// </summary>
    public record ProfitValuation {

        /// <summary>
        /// Erzielbare Jahreskaltmiete
        /// </summary>
        public double ColdRent {
            get;
            init;
        }

        /// <summary>
        /// Bewirtschaftungskosten
        /// </summary>
        public double OperatingCosts {
            get;
            init;
        }

        /// <summary>
        /// Liegenschaftszinsatz
        /// </summary>
        public double PropertyRate {
            get;
            init;
        } = 3;

    }

}