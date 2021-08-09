using System;

namespace Gschwind.Lighthouse.Example.Models.Data {

    /// <summary>
    /// Einmalige Ausgabe
    /// </summary>
    public record SingleExpense : SingleCashFlow {

        /// <summary>
        /// Liquiditätswirksam
        /// </summary>
        public bool IsLiquidityRelevant {
            get;
            init;
        } = true;

        /// <summary>
        /// Ist es eine Sonderausgabe?
        /// </summary>
        public bool IsTaxableExpense {
            get;
            init;
        }

    }

}
