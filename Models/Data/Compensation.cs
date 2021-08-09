using System;

namespace Gschwind.Lighthouse.Example.Models.Data {

    /// <summary>
    /// Abfindung
    /// </summary>
    public record Compensation : SingleCashFlow {

        /// <summary>
        /// Fünftelregelung (§34(1) EStG)
        /// </summary>
        public bool IsFifthPartRule {
            get;
            init;
        }

    }

}
