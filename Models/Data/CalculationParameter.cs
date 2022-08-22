namespace Gschwind.Lighthouse.Example.Models.Data {

    /// <summary>
    /// Berechnung der Auszahlung
    /// </summary>
    public record CalculationParameter {

        /// <summary>
        /// Verzinsung der Kapitalanlage in %
        /// </summary>
        public double CapitalInterest {
            get;
            init;
        }

        /// <summary>
        /// Abschlussgebühr in %
        /// </summary>
        public double AcquisitionCosts {
            get;
            init;
        }

        /// <summary>
        /// Aufteilung der Abschlussgebühr in Jahren
        /// </summary>
        public int AcquisitionCostsYears {
            get;
            init;
        }

        /// <summary>
        /// Verwaltungskosten (in % pro Jahr)
        /// </summary>
        public double AdministrationCosts {
            get;
            init;
        }

        /// <summary>
        /// Kalkulierte Lebenserwartung in Jahren
        /// </summary>
        public int LifeExpectation {
            get;
            init;
        } = 90;

    }

}
