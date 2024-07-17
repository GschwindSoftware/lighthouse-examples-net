namespace Gschwind.Lighthouse.Example.Models.Plans.Settings;

/// <summary>
/// Der Erbe
/// </summary>
public record Testament {

    /// <summary>
    /// Die Erben
    /// </summary>
    public IEnumerable<Heritage> Heirs {
        get;
        init;
    } = [];

    /// <summary>
    /// Liste der Vermächtnisse
    /// </summary>
    public List<Legacy> Legacies {
        get;
        init;
    } = [];

}
