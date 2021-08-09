using System;

namespace Gschwind.Lighthouse.Example.Models.Data {

    /// <summary>
    /// Kauf eines Vorgangs
    /// </summary>
    public record Buying {

        /// <summary>
        /// Wird gekauft?
        /// </summary>
        public bool DoBuy {
            get;
            init;
        }

        /// <summary>
        /// Kaufdatum
        /// </summary>
        public DateTime PurchaseDate {
            get;
            init;
        } = new DateTime(DateTime.Now.Year, 1, 1);

        /// <summary>
        /// Kaufpreis
        /// </summary>
        public double PurchasePrice {
            get;
            init;
        }

    }

}
