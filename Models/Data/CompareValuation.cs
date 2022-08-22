namespace Gschwind.Lighthouse.Example.Models.Data;

/// <summary>
/// Manuelle Bewertung
/// </summary>
public record CompareValuation {

    /// <summary>
    /// Verkehrswert ist Vergleichswert
    /// </summary>
    public bool CompareMarketValue {
        get;
        init;
    } = true;

    /// <summary>
    /// Vergleichswert
    /// </summary>
    public double CompareValue {
        get;
        init;
    }

}
