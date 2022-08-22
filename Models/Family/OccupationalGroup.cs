namespace Gschwind.Lighthouse.Example.Models.Family;

/// <summary>
/// Berufsgruppe
/// </summary>
public enum OccupationalGroup {
    /// <summary>
    /// Angestellt
    /// </summary>
    Employee,
    /// <summary>
    /// Selbständig
    /// </summary>
    SelfEmployed,
    /// <summary>
    /// Beamter
    /// </summary>
    CivilServant,
    /// <summary>
    /// Gesellschafter Geschäftsführer
    /// </summary>
    ShareholdingManagingDirector = 4,
    /// <summary>
    /// Nicht berufstätig
    /// </summary>
    NotEmployed = 6,
    /// <summary>
    /// Geringfügig beschäftigt
    /// </summary>
    MarginalEmployed = 8
}
