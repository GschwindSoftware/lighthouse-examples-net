using System;

namespace Gschwind.Lighthouse.Example.Models.Data {

    /// <summary>
    /// Einkunft aus Gewerbebetrieb
    /// </summary>
    public record BusinessIncome : IncomeBase {

        /// <summary>
        /// Gewerbesteuerhebesatz in %
        /// </summary>
        public double TradeTaxRate {
            get;
            init;
        }

        /// <summary>
        /// Erzeugt eine neue Instanz der <see cref="BusinessIncome"/>-Klasse
        /// </summary>
        public BusinessIncome() =>
            Termination = Termination with { Type = MomentType.AtRetirement };

    }

}