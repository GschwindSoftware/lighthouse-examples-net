namespace Gschwind.Lighthouse.Example.Models.Data {

    /// <summary>
    /// Besteuerung des Verkaufs
    /// </summary>
    public enum Taxation {
        /// <summary>
        /// Steuerfrei
        /// </summary>
        None,
        /// <summary>
        /// Einkommensteuer
        /// </summary>
        IncomeTax = 1,
        /// <summary>
        /// Mit Progressionsvorbehalt
        /// </summary>
        ProgressionClause = 2,
        /// <summary>
        /// Abgeltungsteuer
        /// </summary>
        WithholdingTax = 1000,
        /// <summary>
        /// Teileinkünfteverfahren
        /// </summary>
        PartialIncomeMethod = 1001,
        /// <summary>
        /// Fünftelregelung
        /// </summary>
        FifthPart = 1002,
        /// <summary>
        /// Halber Durchschnittsteuersatz
        /// </summary>
        Half = 1003
    }

}
