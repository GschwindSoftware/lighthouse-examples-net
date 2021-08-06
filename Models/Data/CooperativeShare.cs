using System;
using System.Collections.Generic;
using System.Linq;

namespace Gschwind.Lighthouse.Example.Models.Data {

    /// <summary>
    /// Genossenschaftsanteil
    /// </summary>
    public record CooperativeShare : SecurityInvestment {

        /// <summary>
        /// Risikostufe
        /// </summary>
        public RiskLevel RiskLevel {
            get;
            init;
        } = RiskLevel.NotCritical;

        /// <summary>
        /// Zeitraum
        /// </summary>
        public TimePeriod TimePeriod {
            get;
            init;
        } = new TimePeriod();

        /// <summary>
        /// Wertstellung
        /// </summary>
        public DateTime ValueDate {
            get;
            init;
        } = DateTime.Now.Date;

        /// <summary>
        /// Anzahl Anteile
        /// </summary>
        public double Quantity {
            get;
            init;
        }

        /// <summary>
        /// Preis pro Anteil
        /// </summary>
        public double Price {
            get;
            init;
        }

        /// <summary>
        /// Der Modus
        /// </summary>
        public int Mode {
            get;
            init;
        }

        /// <summary>
        /// Ausschüttungen in Prozent
        /// </summary>
        public ICollection<PercentValue> Dividend {
            get;
            init;
        } = new List<PercentValue>();

        /// <summary>
        /// Wertsteigerung
        /// </summary>
        public double Depreciation {
            get;
            init;
        }

    }

}
