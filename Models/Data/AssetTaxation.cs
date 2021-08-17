namespace Gschwind.Lighthouse.Example.Models.Data {

    /// <summary>
    /// Steuerliche Anrechnung
    /// </summary>
    public enum AssetTaxation {
        /// <summary>
        /// Keine steuerliche Anrechnung
        /// </summary>
        None,
        /// <summary>
        /// Einkommenssteuer
        /// </summary>
        Income,
        /// <summary>
        /// Abgeltungssteuer
        /// </summary>
        FlatRateWitholding = 1000
    }

}
