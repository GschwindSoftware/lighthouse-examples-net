namespace Gschwind.Lighthouse.Example.Models.Data {

    /// <summary>
    /// Abschreibungstyp bei Betrieben
    /// </summary>
    public enum CompanyAmortizationType {
        /// <summary>
        /// Linear
        /// </summary>
        Linear,
        /// <summary>
        /// Degressiv
        /// </summary>
        Degressive = 1,
        /// <summary>
        /// Manuell
        /// </summary>
        Manual = 2,
        /// <summary>
        /// Keine
        /// </summary>
        NoAmortization = 100
    }

}
