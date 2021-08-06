using System;

namespace Gschwind.Lighthouse.Example.Models.Data {

    /// <summary>
    /// Rentenbezug
    /// </summary>
    public record PensionIncome : IncomeBase {

        /// <summary>
        /// Steuerliche Begünstigung
        /// </summary>
        public PensionTaxAdvantage TaxAdvantage {
            get;
            init;
        } = PensionTaxAdvantage.YearlyAllowance;

        /// <summary>
        /// Jährlicher Freibetrag
        /// </summary>
        public double YearlyAllowance {
            get;
            init;
        }

        /// <summary>
        /// Ertragsanteil in %
        /// </summary>
        public double PensionAllowance {
            get;
            init;
        } = 100;

        /// <summary>
        /// Erzeugt eine neue Instanz der <see cref="PensionIncome"/>-Klasse
        /// </summary>
        public PensionIncome() =>
            CashFlows = CashFlows with { Period = Period.Monthly };

    }

}