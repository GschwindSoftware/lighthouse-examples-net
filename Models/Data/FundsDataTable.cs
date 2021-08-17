using System.Collections.Generic;
using System.Linq;

namespace Gschwind.Lighthouse.Example.Models.Data {

    /// <summary>
    /// Stammdaten für geschlossene Fonds
    /// </summary>
    public record FundsDataTable {

        /// <summary>
        /// Einzahlungen in % der Beteiligungssumme
        /// </summary>
        public ICollection<PercentValue> Payments {
            get;
            init;
        } = new List<PercentValue>();

        /// <summary>
        /// Ausschüttungen in % der Beteiligungssumme
        /// </summary>
        public ICollection<PercentValue> Distriubtions {
            get;
            init;
        } = new List<PercentValue>();

        /// <summary>
        /// Besteuerung in % der Beteiligungssumme
        /// </summary>
        public ICollection<PercentValue> Taxable {
            get;
            init;
        } = new List<PercentValue>();

        /// <summary>
        /// Verkäufe in % der Beteiligungssumme
        /// </summary>
        public ICollection<PercentValue> Sales {
            get;
            init;
        } = new List<PercentValue>();

        /// <summary>
        /// Besteuerung des Verkäufe in % der Beteiligungssumme
        /// </summary>
        public ICollection<PercentValue> TaxableSales {
            get;
            init;
        } = new List<PercentValue>();

        /// <summary>
        /// Marktwert in % der Beteiligungssumme
        /// </summary>
        public ICollection<PercentValue> MarketValues {
            get;
            init;
        } = new List<PercentValue>();

    }

}
