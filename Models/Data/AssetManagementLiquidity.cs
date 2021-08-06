using System;

namespace Gschwind.Lighthouse.Example.Models.Data {

    /// <summary>
    /// Liquiditätskonto
    /// </summary>
    public record AssetManagementLiquidity : SubData {

        /// <summary>
        /// Zuordnung zur Bilanz
        /// </summary>
        public AssetBalanceType BalanceType {
            get;
            init;
        }

        /// <summary>
        /// Zinssatz Haben in %
        /// </summary>
        public double DebitRate {
            get;
            init;
        }

    }

}