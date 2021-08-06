namespace Gschwind.Lighthouse.Example.Models.Family {

    /// <summary>
    /// Zuordnung eines Kindes zu einem Riestervertrag
    /// </summary>
    public enum RiesterChildAssignment {
        /// <summary>
        /// Kunde
        /// </summary>
        Client,
        /// <summary>
        /// Partner
        /// </summary>
        Partner = 1,
        /// <summary>
        /// Automatisch
        /// </summary>
        Automatic = 2,
        /// <summary>
        /// Keiner
        /// </summary>
        None = 3
    }

}