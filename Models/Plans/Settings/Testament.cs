using System.Collections.Generic;
using System.Linq;

namespace Gschwind.Lighthouse.Example.Models.Plans.Settings {

    /// <summary>
    /// Der Erbe
    /// </summary>
    public record Testament {

        /// <summary>
        /// Die Erben
        /// </summary>
        public IEnumerable<Heritage> Heirs {
            get;
            init;
        } = Enumerable.Empty<Heritage>();

        /// <summary>
        /// Liste der Vermächtnisse
        /// </summary>
        public List<Legacy> Legacies {
            get;
            init;
        } = new List<Legacy>();

    }

}