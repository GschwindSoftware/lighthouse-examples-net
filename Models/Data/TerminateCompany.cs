namespace Gschwind.Lighthouse.Example.Models.Data {

    /// <summary>
    /// Gesellschaft verkaufen
    /// </summary>
    public record TerminateCompany : Termination {

        /// <summary>
        /// Restbuchwert
        /// </summary>
        public double RemainingBookValue {
            get;
            init;
        }

        /// <summary>
        /// Besteuerung
        /// </summary>
        public Taxation SaleTaxation {
            get;
            init;
        }

        /// <summary>
        /// Freibetrag beim Verkauf nach §16 EStG anwenden
        /// </summary>
        public bool SaleAllowance {
            get;
            init;
        }

    }

}
