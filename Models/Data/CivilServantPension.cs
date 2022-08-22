namespace Gschwind.Lighthouse.Example.Models.Data;

/// <summary>
/// Beamtenpension
/// </summary>
public record CivilServantPension : StatePension {
    /// <summary>
    /// Automatisch 55% oder 60% der Altersrente nehmen
    /// </summary>
    public bool AutomaticWidowsPension {
        get;
        init;
    } = true;
}
