using System;

namespace Gschwind.Lighthouse.Example.Models.Data {

    /// <summary>
    /// Wertpapieranlage
    /// </summary>
    public abstract record SecurityInvestment : SecurityBase {

        /// <summary>
        /// Name des Instituts
        /// </summary>
        public string Institute {
            get;
            init;
        } = String.Empty;

        /// <summary>
        /// Kontonummer
        /// </summary>
        public string AccountNumber {
            get;
            init;
        } = String.Empty;

        /// <summary>
        /// Jährliche Gebühr in %
        /// </summary>
        public double AnnualFeeRate {
            get;
            init;
        }

        /// <summary>
        /// Maximale Jahresgebühr (EUR)
        /// </summary>
        public double AnnualFeeMaximum {
            get;
            init;
        }

        /// <summary>
        /// Sind die Gebühren steuerlich relevant?
        /// </summary>
        public bool IsFeeTaxable {
            get;
            init;
        }

        /// <summary>
        /// Steuerlich zu berücksichtigender Anteil der Gebühren in %
        /// </summary>
        public double TaxableFeeRate {
            get;
            init;
        } = 50;

    }

}
