namespace Gschwind.Lighthouse.Example.Models.Data;

/// <summary>
/// Steuerliche Berücksichtigung der Haushaltsnahen Dienstleistungen
/// </summary>
public enum HousehouldServiceType {
    /// <summary>
    /// Keine
    /// </summary>
    None,
    /// <summary>
    /// Minijob
    /// </summary>
    MiniJob = 1,
    /// <summary>
    /// Dienstleistung
    /// </summary>
    Service = 2,
    /// <summary>
    /// Handwerkerleistung
    /// </summary>
    Craftsman = 3
}
