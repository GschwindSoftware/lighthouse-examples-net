namespace Gschwind.Lighthouse.Example.Models.Data {

    /// <summary>
    /// Marktwerte sind eine Reihe von Werten zu einem bestimmten Zeitpunkt (Stützstellen). Werte zwischen den Stützstellen werden interpoliert
    /// </summary>
    public record MarketValues {

        /// <summary>
        /// Liste von Zahlungsflüssen
        /// </summary>
        public ICollection<DateValue> Values {
            get;
            init;
        } = new List<DateValue>();

        /// <summary>
        /// Wertsteigerung nach dem letzten eingetragenen Verkehrswert
        /// </summary>
        public double Increase {
            get;
            init;
        }

    }

}
