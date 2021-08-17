using System;

namespace Gschwind.Lighthouse.Example.Models.Data {

    /// <summary>
    /// Steuerliche Bewertung von Immobilien in der Erbschaftsteuer
    /// </summary>
    public record PropertyValuation {

        /// <summary>
        /// Bewertungsart
        /// </summary>
        public PropertyValuationType PropertyType {
            get;
            init;
        } = PropertyValuationType.Developed;

        /// <summary>
        /// Grundstücksart
        /// </summary>
        public LandType LandType {
            get;
            init;
        } = LandType.Family;

        /// <summary>
        /// Bewertungsmethode
        /// </summary>
        public ValuationMethod ValuationMethod {
            get;
            init;
        }

        /// <summary>
        /// Bewertung
        /// </summary>
        public GroundValuation GroundValuation {
            get;
            init;
        } = new();

        /// <summary>
        /// Bewertung des Gebäudes
        /// </summary>
        public BuildingValuation BuildingValuation {
            get;
            init;
        } = new();

        /// <summary>
        /// Ertragswert des Gebäudes
        /// </summary>
        public ProfitValuation ProfitValuation {
            get;
            init;
        } = new();

        /// <summary>
        /// Vergleichswert
        /// </summary>
        public CompareValuation CompareValuation {
            get;
            init;
        } = new();

        /// <summary>
        /// Erbbau
        /// </summary>
        public LeaseholdValuation LeaseholdValuation {
            get;
            init;
        } = new();

        /// <summary>
        /// Gesamtnutzungsdauer
        /// </summary>
        public int UsefulLife {
            get;
            init;
        } = 70;

        /// <summary>
        /// Modernisierungsgrad
        /// </summary>
        public Modernization Modernization {
            get;
            init;
        } = Modernization.NotModernized;

        /// <summary>
        /// Marktanpassung in %
        /// </summary>
        public double MarketAdjustment {
            get;
            init;
        } = 100.0;

    }

}
