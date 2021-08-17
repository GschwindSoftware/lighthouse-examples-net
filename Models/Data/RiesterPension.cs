using System.Collections.Generic;
using System.Linq;

namespace Gschwind.Lighthouse.Example.Models.Data {

    /// <summary>
    /// Riesterrente
    /// </summary>
    public record RiesterPension : PrivatePension {

        /// <summary>
        /// Bereits erhaltene Zulagen
        /// </summary>
        public ICollection<DateValue> AlreadyReceivedBonus {
            get;
            init;
        } = new List<DateValue>();

    }

}
