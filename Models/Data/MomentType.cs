namespace Gschwind.Lighthouse.Example.Models.Data;

/// <summary>
/// Art des Zeitpunktes
/// </summary>
public enum MomentType {
    /// <summary>
    /// An einem bestimmten Datum
    /// </summary>
    AtDate,
    /// <summary>
    /// Nie
    /// </summary>
    Never,
    /// <summary>
    /// Bei Renteneintritt
    /// </summary>
    AtRetirement,
    /// <summary>
    /// Zu einem bestimmten Alter
    /// </summary>
    AtAge = 6
}
