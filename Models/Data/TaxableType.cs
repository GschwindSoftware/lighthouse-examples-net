namespace Gschwind.Lighthouse.Example.Models.Data {

    /// <summary>
    /// Art der Besteuerung
    /// </summary>
    public enum TaxableType {
        /// <summary>
        /// Ausland ohne Besteuerung
        /// </summary>
        ForeignTaxFree,
        /// <summary>
        /// Inland
        /// </summary>
        Domestic,
        /// <summary>
        /// Ausland mit Progressionsvorbehalt
        /// </summary>
        ForeignWithProgressionClause
    }

}
