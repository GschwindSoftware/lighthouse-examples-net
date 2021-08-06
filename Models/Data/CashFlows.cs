using System.Collections.Generic;
using System.Linq;

namespace Gschwind.Lighthouse.Example.Models.Data {

    /// <summary>
    /// Klasse zur Erfassung von Zahlungsströmen
    /// </summary>
    public record CashFlows {

        /// <summary>
        /// Zahlungsintervall
        /// </summary>
        public Period Period {
            get;
            init;
        }

        /// <summary>
        /// Liste von Zahlungsflüssen
        /// </summary>
        public ICollection<CashFlow> Values {
            get;
            init;
        } = new List<CashFlow>();

        /// <summary>
        /// Liste von Steigerungen
        /// </summary>
        public ICollection<PercentValue> Increases {
            get;
            init;
        } = new List<PercentValue>();

    }

}