namespace Gschwind.Lighthouse.Example.Models.Data {

    /// <summary>
    /// Typ der steuerlichen Ausgabe im Darlehen
    /// </summary>
    public enum TaxableLoanType {
        /// <summary>
        /// Automatisch
        /// </summary>
        Automatic,
        /// <summary>
        /// Land- und Forstwirtschaft
        /// </summary>
        Agriculture = 1,
        /// <summary>
        /// Gewerbebetrieb
        /// </summary>
        Business = 2,
        /// <summary>
        /// Selbständige Arbeit
        /// </summary>
        SelfEmployed = 3,
        /// <summary>
        /// Kapitalvermögen
        /// </summary>
        Capital = 6,
        /// <summary>
        /// Vermietung und Verpachtung
        /// </summary>
        LettingAndLeasing = 7,
        /// <summary>
        /// Sonstige Einkünfte
        /// </summary>
        Other = 8
    }

}
