using System.Collections.Generic;

namespace Gschwind.Lighthouse.Example.Models.Reports {

    /// <summary>
    /// Eine hierarchische Reihe von Datenpunkten
    /// </summary>
    public record HierarchicalDataSeries {

        /// <summary>
        /// Der Titel der Reihe
        /// </summary>
        public string Title {
            get;
            private set;
        } = "";

        /// <summary>
        /// Beschreibt, wie die Datenpunkte zu interpretieren sind
        /// </summary>
        public DataPointType Type {
            get;
            private set;
        }

        /// <summary>
        /// Die Datenpunkte der Reihe
        /// </summary>
        public IEnumerable<double> Data {
            get;
            private set;
        } = System.Array.Empty<double>();

        /// <summary>
        /// Untergeordnete Reihen, die zusammen die Daten dieser Reihe bilden
        /// </summary>
        public IEnumerable<HierarchicalDataSeries> Series {
            get;
            private set;
        } = System.Array.Empty<HierarchicalDataSeries>();

    }

}
