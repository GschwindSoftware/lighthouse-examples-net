using System;

namespace Gschwind.Lighthouse.Example.Models.Data {

    /// <summary>
    /// Regelleistung
    /// </summary>
    public record StandardBenefit : CashflowSubFinance {

        /// <summary>
        /// Fallzahl
        /// </summary>
        public int NumberOfCases {
            get;
            init;
        } = 1;

        /// <summary>
        /// Prozentsatz der Abschlagzahlung
        /// </summary>
        public double AdvancePaymentRate {
            get;
            init;
        } = 50;

        /// <summary>
        /// Tage nachdem die Restzahlung erfolgt
        /// </summary>
        public int FinalPaymentDays {
            get;
            init;
        } = 90;

        /// <summary>
        /// Erzeugt eine neue Instanz der <see cref="StandardBenefit"/>-Klasse
        /// </summary>
        public StandardBenefit() =>
            CashFlows = CashFlows with { Period = Period.Quarterly };

    }

}
