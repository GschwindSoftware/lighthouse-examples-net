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
        OHG = 1,
        /// <summary>
        /// Kommanditgesellschaft
        /// </summary>
        KG = 2,
        /// <summary>
        /// Partnerschaftsgesellschaft
        /// </summary>
        Partnership = 3,
        /// <summary>
        /// Stille Gesellschaft
        /// </summary>
        SilentPartnership = 4,
        /// <summary>
        /// GmbH und Co. KG
        /// </summary>
        GmbHCoKG = 5
    }

}
