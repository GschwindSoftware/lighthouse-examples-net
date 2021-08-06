namespace Gschwind.Lighthouse.Example.Models.Data {

    /// <summary>
    /// Steuerliche Anrechnung der Unterhaltszahlung
    /// </summary>
    public enum AlimonyTaxType {
        /// <summary>
        /// Außergewöhnliche Belastung
        /// </summary>
        ExceptionalCosts,
        /// <summary>
        /// Sonderausgabe
        /// </summary>
        OtherExpenses = 1,
        /// <summary>
        /// Steuerlich nicht relevant
        /// </summary>
        NotTaxable = 2
    }

}
