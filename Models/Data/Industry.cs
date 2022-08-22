namespace Gschwind.Lighthouse.Example.Models.Data {

    /// <summary>
    /// Branche
    /// </summary>
    public record Industry {

        /// <summary>
        /// Anteil
        /// </summary>
        public double Quote {
            get;
            init;
        }

        /// <summary>
        /// Name der Branche
        /// </summary>
        public string Name {
            get;
            init;
        } = String.Empty;

    }

}
