namespace Gschwind.Lighthouse.Example.Models.Data;

/// <summary>
/// Nachrichtliche Informationen
/// </summary>
public record Informations {

    /// <summary>
    /// Notizen
    /// </summary>
    public string Notes {
        get;
        init;
    } = String.Empty;

    /// <summary>
    /// Noch zu erledigen
    /// </summary>
    public string Todo {
        get;
        init;
    } = String.Empty;

    /// <summary>
    /// Letztes Änderungsdatum
    /// </summary>
    public DateTime LastChanged {
        get;
        init;
    } = DateTime.Now.Date;

    /// <summary>
    /// Letzter Benutzer
    /// </summary>
    public string LastUser {
        get;
        init;
    } = String.Empty;

}
