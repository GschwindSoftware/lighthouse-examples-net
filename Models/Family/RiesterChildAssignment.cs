namespace Gschwind.Lighthouse.Example.Models.Family;

/// <summary>
/// Zuordnung eines Kindes zu einem Riestervertrag
/// </summary>
public enum RiesterChildAssignment {
    /// <summary>
    /// Kunde
    /// </summary>
    Client,
    /// <summary>
    /// Partner
    /// </summary>
    Partner,
    /// <summary>
    /// Automatisch
    /// </summary>
    Automatic,
    /// <summary>
    /// Keiner
    /// </summary>
    None
}
