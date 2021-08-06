namespace Gschwind.Lighthouse.Example.Models.Data {

    /// <summary>
    /// Steuerliche Begünstigung des Betriebsvermögens für die Erbschaftsteuer
    /// </summary>
    public enum CompanyBenefitType {
        /// <summary>
        /// Keine Begünstigung
        /// </summary>
        None,
        /// <summary>
        /// Regelverschonung (85% steuerfrei)
        /// </summary>
        RegularExemption = 1,
        /// <summary>
        /// Verschonungsoption (100% steuerfrei)
        /// </summary>
        ExemptionOption = 2
    }

}
