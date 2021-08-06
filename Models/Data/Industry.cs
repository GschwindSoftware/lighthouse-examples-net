using System;

namespace Gschwind.Lighthouse.Example.Models.Data {

    /// <summary>
    /// Industry
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
        /// Name der Industry
        /// </summary>
        public string Name {
            get;
            init;
        } = String.Empty;

    }

}
