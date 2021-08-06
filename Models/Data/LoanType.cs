namespace Gschwind.Lighthouse.Example.Models.Data {

    /// <summary>
    /// Darlehensart
    /// </summary>
    public enum LoanType {
        /// <summary>
        /// Annuitätendarlehen
        /// </summary>
        Annuity,
        /// <summary>
        /// Endfälliges Darlehen
        /// </summary>
        Bullet = 1,
        /// <summary>
        /// Tilgungsdarlehen
        /// </summary>
        Amortizing = 2
    }

}
