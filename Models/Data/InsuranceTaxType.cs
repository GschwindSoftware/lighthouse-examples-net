namespace Gschwind.Lighthouse.Example.Models.Data {

    /// <summary>
    /// Steuerbegünstigung von Beiträgen zur bAV
    /// </summary>
    public enum InsuranceTaxType {
        /// <summary>
        /// Freibetrag (neues Recht §3 Nr. 63 EStG)
        /// </summary>
        Allowance,
        /// <summary>
        /// Pauschalbesteuerung (altes Recht §40b EStG)
        /// </summary>
        FlatRateTaxation = 1
    }

}
