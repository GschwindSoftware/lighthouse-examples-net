namespace Gschwind.Lighthouse.Example.Models.Data {

    /// <summary>
    /// Art der Gesellschaft
    /// </summary>
    public enum CompanyType {
        /// <summary>
        /// Einzelunternehmen
        /// </summary>
        IndividualCompany = -10,
        /// <summary>
        /// Gesellschaft bürgerlichen Rechts
        /// </summary>
        GbR = 0,
        /// <summary>
        /// Offene Handelsgesellschaft
        /// </summary>
        OHG,
        /// <summary>
        /// Kommanditgesellschaft
        /// </summary>
        KG,
        /// <summary>
        /// Partnerschaftsgesellschaft
        /// </summary>
        Partnership,
        /// <summary>
        /// Stille Gesellschaft
        /// </summary>
        SilentPartnership,
        /// <summary>
        /// GmbH und Co. KG
        /// </summary>
        GmbHCoKG
    }

}
