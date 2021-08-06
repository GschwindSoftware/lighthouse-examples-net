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
        Agriculture = 1,
        /// <summary>
        /// Werbungskosten für Gewerbebetrieb
        /// </summary>
        Business = 2,
        /// <summary>
        /// Werbungskosten für Selbständige Arbeit
        /// </summary>
        SelfEmployed = 3,
        /// <summary>
        /// Werbungskosten für Nichtselbständige Arbeit
        /// </summary>
        Employed = 4,
        /// <summary>
        /// Werbungskosten für Kapitalvermögen
        /// </summary>
        Capital = 6,
        /// <summary>
        /// Werbungskosten für Vermietung und Verpachtung
        /// </summary>
        LettingAndLeasing = 7,
        /// <summary>
        /// Werbungskosten für Sonstige Einkünfte
        /// </summary>
        Other = 8,
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
