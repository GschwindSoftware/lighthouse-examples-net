namespace Gschwind.Lighthouse.Example.Models.Data {

    /// <summary>
    /// Region
    /// </summary>
    public record Region {

        /// <summary>
        /// Anteil
        /// </summary>
        public double Quote {
            get;
            init;
        }

        /// <summary>
        /// Name der Region
        /// </summary>
        public string Name {
            get;
            init;
        } = string.Empty;

    }

}
