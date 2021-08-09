using System;

namespace Gschwind.Lighthouse.Example.Models.Data {

    /// <summary>
    /// Sonstige Einkunft
    /// </summary>
    public record OtherIncome : IncomeBase {

        /// <summary>
        /// Liquiditätswirksam
        /// </summary>
        public bool IsLiquidityRelevant {
            get;
            init;
        } = true;

        /// <summary>
        /// Einkunftsart
        /// </summary>
        public IncomeType IncomeType {
            get;
            init;
        } = IncomeType.Other;

        /// <summary>
        /// Besteuerung
        /// </summary>
        public Taxation Taxation {
            get;
            init;
        } = Taxation.IncomeTax;

        /// <summary>
        /// Erzeugt eine neue Instanz der <see cref="OtherIncome"/>-Klasse
        /// </summary>
        public OtherIncome() =>
            ScenarioParameter = ScenarioParameter with { Death = 100 };

    }

}
