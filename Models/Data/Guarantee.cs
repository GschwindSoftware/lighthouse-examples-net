using System;

namespace Gschwind.Lighthouse.Example.Models.Data {

    /// <summary>
    /// Bürgschaft
    /// </summary>
    public record Guarantee : LiabilityBase {

        /// <summary>
        /// Wert der Bürgschaft
        /// </summary>
        public double GuaranteeValue {
            get;
            init;
        }

    }

}