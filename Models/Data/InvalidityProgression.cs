namespace Gschwind.Lighthouse.Example.Models.Data;

/// <summary>
/// Progression bei Invalidität
/// </summary>
public enum InvalidityProgression {
    /// <summary>
    /// Keine
    /// </summary>
    None,
    /// <summary>
    /// 225 %
    /// </summary>
    Progression_225 = 225,
    /// <summary>
    /// 300 %
    /// </summary>
    Progression_300 = 300,
    /// <summary>
    /// 350 %
    /// </summary>
    Progression_350 = 350,
    /// <summary>
    /// 500 %
    /// </summary>
    Progression_500 = 500,
    /// <summary>
    /// 600 %
    /// </summary>
    Progression_600 = 600,
    /// <summary>
    /// 1000 %
    /// </summary>
    Progression_1000 = 1000,
    /// <summary>
    /// Feste Leistung
    /// </summary>
    Fixed = -200,
}
