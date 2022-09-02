namespace Gschwind.Lighthouse.Example.Models.Data;

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
    NotCritical,
    /// <summary>
    /// Konservativ
    /// </summary>
    LessCricital,
    /// <summary>
    /// Wachstumsorientiert
    /// </summary>
    ModeratelyCritical,
    /// <summary>
    /// Offensiv
    /// </summary>
    Critical,
    /// <summary>
    /// Spekulativ
    /// </summary>
    HighlyCritical
}
