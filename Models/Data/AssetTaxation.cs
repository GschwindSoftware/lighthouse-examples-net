namespace Gschwind.Lighthouse.Example.Models.Data {

    /// <summary>
    /// Steuerliche Anrechnung
    /// </summary>
    public enum AssetTaxation {
        /// <summary>
        /// -
        /// </summary>
        None,
        /// <summary>
        /// Einkommenssteuer
        /// </summary>
        Income = 1,
        /// <summary>
        /// Abgeltungssteuer
        /// </summary>
        FlatRateWitholding = 1000
    }

}
