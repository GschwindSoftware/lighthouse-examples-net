namespace Gschwind.Lighthouse.Example.Models.Data;

/// <summary>
/// Bewertungsart der Immobilien
/// </summary>
public enum Modernization {
    /// <summary>
    /// Nicht modernisiert
    /// </summary>
    NotModernized = 1,
    /// <summary>
    /// Instandhaltungsmaßnahmen
    /// </summary>
    Maintenance = 4,
    /// <summary>
    /// Mittel
    /// </summary>
    Medium = 8,
    /// <summary>
    /// Überwiegend
    /// </summary>
    Mainly = 13,
    /// <summary>
    /// Umfassend
    /// </summary>
    Comprehensive = 18
}
