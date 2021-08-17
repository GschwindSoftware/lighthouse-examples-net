using System;
using System.Collections.Generic;
using System.Linq;

namespace Gschwind.Lighthouse.Example.Models.Data {

    /// <summary>
    /// Ausgereichtes Darlehen
    /// </summary>
    public record LoanGranted : AssetBase {

        /// <summary>
        /// Darlehensnominalbetrag
        /// </summary>
        public double LoanAmount {
            get;
            init;
        }

        /// <summary>
        /// Darlehensart
        /// </summary>
        public LoanType LoanType {
            get;
            init;
        } = LoanType.Annuity;

        /// <summary>
        /// Zeitraum
        /// </summary>
        public TimePeriod TimePeriod {
            get;
            init;
        } = new() { EndType = MomentType.AtDate };

        /// <summary>
        /// Restschuld
        /// </summary>
        public DateValue RemainingDebt {
            get;
            init;
        } = new();

        /// <summary>
        /// Disagio
        /// </summary>
        public double Disagio {
            get;
            init;
        }

        /// <summary>
        /// Start der Tilgung bei Darlehensbeginn
        /// </summary>
        public bool IsPaymentAutomated {
            get;
            init;
        } = true;

        /// <summary>
        /// Annuität in EUR bei Annuitätendarlehen / Tilgung in EUR bei Tilgungsdarlehen
        /// </summary>
        public ICollection<DateValue> Repayments {
            get;
            init;
        } = new List<DateValue>();

        /// <summary>
        /// Tilgungsintervall
        /// </summary>
        public Period RepaymentInterval {
            get;
            init;
        } = Period.Monthly;

        /// <summary>
        /// Sondertilgungen
        /// </summary>
        public ICollection<DateValue> AdditionalRepayments {
            get;
            init;
        } = new List<DateValue>();

        /// <summary>
        /// Zinssätze in %
        /// </summary>
        public ICollection<PercentValue> InterestRates {
            get;
            init;
        } = new List<PercentValue>();

        /// <summary>
        /// Einkunftsart
        /// </summary>
        public AssetTaxation AssetTaxation {
            get;
            init;
        } = AssetTaxation.Income;

    }

}
