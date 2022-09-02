namespace Gschwind.Lighthouse.Example.Models.Data;

/// <summary>
/// Weitere Beitragszahlungen
/// </summary>
public enum FurtherPremiumType {
    /// <summary>
    /// Fortführen
    /// </summary>
    Continue,
    /// <summary>
    /// Beitragsbefreiung
    /// </summary>
    Contribution,
    /// <summary>
    /// Beitragsbefreiung (reduzierte Auszahlung)
    /// </summary>
    ContributionReduced = 3,
}
