namespace Gschwind.Lighthouse.Example.Models.Data {

    /// <summary>
    /// Beitragszuschuss im Ruhestand
    /// </summary>
    public enum GrantPensionType {
        /// <summary>
        /// Kein Zuschuss
        /// </summary>
        None,
        /// <summary>
        /// Arbeitgeberzuschuss
        /// </summary>
        EmployerGrant = 1,
        /// <summary>
        /// Rentenversicherungsträger
        /// </summary>
        PensionInsuranceInstitute = 2
    }

}
