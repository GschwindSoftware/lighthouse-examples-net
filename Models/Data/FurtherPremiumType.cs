namespace Gschwind.Lighthouse.Example.Models.Data {

    /// <summary>
    /// Weitere Beitragszahlungen
    /// </summary>
    public enum FurtherPremiumType {
        /// <summary>
        /// Fortführen
        /// </summary>
        Continue = 0,
        /// <summary>
        /// Beitragsbefreiung
        /// </summary>
        Contribution = 1,
        /// <summary>
        /// Beitragsbefreiung (reduzierte Auszahlung)
        /// </summary>
        ContributionReduced = 3,
    }

}
