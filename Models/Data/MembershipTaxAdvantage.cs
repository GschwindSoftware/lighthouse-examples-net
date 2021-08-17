namespace Gschwind.Lighthouse.Example.Models.Data {

    /// <summary>
    /// Steuerliche Begünstigung für Mietgliedsbeiträge
    /// </summary>
    public enum MembershipTaxAdvantage {
        /// <summary>
        /// Keine Begünstigung
        /// </summary>
        None,
        /// <summary>
        /// Gemeinnütziger Verein
        /// </summary>
        PublicCharity = 1,
        /// <summary>
        /// Politische Partei
        /// </summary>
        PoliticalParty = 2
    }

}
