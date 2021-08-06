namespace Gschwind.Lighthouse.Example.Models.Data {

    /// <summary>
    /// Risikostufe
    /// </summary>
    public enum RiskLevel {
        /// <summary>
        /// - Keine -
        /// </summary>
        None,
        /// <summary>
        /// Risikolos
        /// </summary>
        NotCritical = 1,
        /// <summary>
        /// Konservativ
        /// </summary>
        LessCricital = 2,
        /// <summary>
        /// Wachstumsorientiert
        /// </summary>
        ModeratelyCritical = 3,
        /// <summary>
        /// Offensiv
        /// </summary>
        Critical = 4,
        /// <summary>
        /// Spekulativ
        /// </summary>
        HighlyCritical = 5
    }

}
