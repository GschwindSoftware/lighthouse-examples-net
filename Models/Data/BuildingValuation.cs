using System;

namespace Gschwind.Lighthouse.Example.Models.Data {

    /// <summary>
    /// Sachwertverfahren
    /// </summary>
    public record BuildingValuation {

        /// <summary>
        /// Grundfläche des Gebäudes
        /// </summary>
        public int BuildingArea {
            get;
            init;
        }

        /// <summary>
        /// Herstellungskosten pro qm
        /// </summary>
        public double ProductionCosts {
            get;
            init;
        }

    }

}