namespace Gschwind.Lighthouse.Example.Models.Data;

/// <summary>
/// Finanzinstrument
/// </summary>
public record Instrument {

    /// <summary>
    /// Anteil am Portfolio.
    /// </summary>
    public double Quote {
        get;
        init;
    }

    /// <summary>
    /// Name des Finanz-Instruments.
    /// </summary>
    public string Name {
        get;
        init;
    } = String.Empty;

}
