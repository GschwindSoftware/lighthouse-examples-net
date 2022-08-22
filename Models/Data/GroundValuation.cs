namespace Gschwind.Lighthouse.Example.Models.Data {

    /// <summary>
    /// Bewertung des Grundstücks
    /// </summary>
    public record GroundValuation {

        /// <summary>
        /// Grundfläche des Grundstücks
        /// </summary>
        public int GroundArea {
            get;
            init;
        }

        /// <summary>
        /// Bodenrichtwert
        /// </summary>
        public double GroundValue {
            get;
            init;
        }

    }

}
