using System;

namespace Gschwind.Lighthouse.Example.Models.Data {

    /// <summary>
    /// Sonstige Verbindlichkeit
    /// </summary>
    public record OtherLiability : LiabilityBase {

        /// <summary>
        /// Liquiditätswirksam
        /// </summary>
        public bool IsLiquidityRelevant {
            get;
            init;
        } = true;

        /// <summary>
        /// Verbindlichkeiten
        /// </summary>
        public MarketValues Liabilities {
            get;
            init;
        } = new MarketValues();

    }

}