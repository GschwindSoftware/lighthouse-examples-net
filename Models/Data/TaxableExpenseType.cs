namespace Gschwind.Lighthouse.Example.Models.Data {

    /// <summary>
    /// Typ der steuerlichen Ausgabe
    /// </summary>
    public enum TaxableExpenseType {
        /// <summary>
        /// Nicht relevant
        /// </summary>
        None,
        /// <summary>
        /// Werbungskosten für Land- und Forstwirtschaft
        /// </summary>
        Agriculture,
        /// <summary>
        /// Werbungskosten für Gewerbebetrieb
        /// </summary>
        Business,
        /// <summary>
        /// Werbungskosten für Selbständige Arbeit
        /// </summary>
        SelfEmployed,
        /// <summary>
        /// Werbungskosten für Nichtselbständige Arbeit
        /// </summary>
        Employed,
        /// <summary>
        /// Werbungskosten für Kapitalvermögen
        /// </summary>
        Capital = 6,
        /// <summary>
        /// Werbungskosten für Vermietung und Verpachtung
        /// </summary>
        LettingAndLeasing,
        /// <summary>
        /// Werbungskosten für Sonstige Einkünfte
        /// </summary>
        Other,
        /// <summary>
        /// Sonderausgaben
        /// </summary>
        TaxableExpense = 100,
        /// <summary>
        /// Außergewöhnliche Belastungen
        /// </summary>
        ExceptionalCosts = 101,
        /// <summary>
        /// Außergewöhnliche Belastungen in besonderen Fällen
        /// </summary>
        SpecialExceptionalCosts = 102
    }

}
