using System;

namespace Gschwind.Lighthouse.Example.Models.Data {

    /// <summary>
    /// Verkauf
    /// </summary>
    public record Selling {

        /// <summary>
        /// Zeitpunkt des Verkaufs
        /// </summary>
        public Moment Moment {
            get;
            init;
        } = new Moment();

        /// <summary>
        /// Verkaufsmethode
        /// </summary>
        public SellingMode SellingMode {
            get;
            init;
        } = SellingMode.MarketValue;

        /// <summary>
        /// Verkaufspreis
        /// </summary>
        public double SellingPrice {
            get;
            init;
        }

    }

}