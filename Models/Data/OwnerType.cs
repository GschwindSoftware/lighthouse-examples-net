namespace Gschwind.Lighthouse.Example.Models.Data {

    /// <summary>
    /// Besitzertype
    /// </summary>
    public enum OwnerType {
        /// <summary>
        /// Kunde
        /// </summary>
        Client,
        /// <summary>
        /// Partner
        /// </summary>
        Partner = 1,
        /// <summary>
        /// Kunde + Partner
        /// </summary>
        Both = 2,
        /// <summary>
        /// Sonstige Person
        /// </summary>
        Other = 3,
        /// <summary>
        /// Individuell
        /// </summary>
        Individual = 66
    }

}
