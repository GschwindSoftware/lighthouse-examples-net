namespace Gschwind.Lighthouse.Example.Models.Data;

/// <summary>
/// Dienstwagen
/// </summary>
public record CompanyCar {

    /// <summary>
    /// Neuwert
    /// </summary>
    public double OriginalValue {
        get;
        init;
    }

    /// <summary>
    /// Entfernung zum Arbeitsplatz in km
    /// </summary>
    public int DistanceToWork {
        get;
        init;
    }

}
