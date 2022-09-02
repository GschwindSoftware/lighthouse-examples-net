namespace Gschwind.Lighthouse.Example.Models.Data;

/// <summary>
/// Art der Besteuerung
/// </summary>
public enum VocationalTrainingTaxation {
    /// <summary>
    /// Nicht relevant
    /// </summary>
    None,
    /// <summary>
    /// Werbungskosten selbständige Arbeit
    /// </summary>
    SelfEmployed = 3,
    /// <summary>
    /// Werbungskosten nichtselbständige Arbeit
    /// </summary>
    Employed = 4,
    /// <summary>
    /// Erstausbildung
    /// </summary>
    InitialEducation = 100
}
