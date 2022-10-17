using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Gschwind.Lighthouse.Example.Models.Data;

/// <summary>
/// Basis für alle Vorgänge
/// </summary>
public abstract record PlanData {

    [JsonExtensionData]
    Dictionary<string, JToken> _additionalData = new();

    /// <summary>
    /// Die eindeutige Id des Vorgangs
    /// </summary>
    public Guid Id {
        get;
        init;
    } = Guid.NewGuid();

    /// <summary>
    /// Ein eindeutiger Schlüssel, der einen externen Datensatz in Bezug bringt, falls der Vorgang importiert wurde
    /// </summary>
    /// <seealso cref="ImportId"/>
    public string ImportId {
        get;
        init;
    } = String.Empty;

    /// <summary>
    /// Der Name des Synchronisations-Anbieters, der den Vorgang aus externen Daten importiert hat
    /// </summary>
    /// <seealso cref="ImportProvider"/>
    public string? ImportProvider {
        get;
        init;
    }

    /// <summary>
    /// Vorgangsname
    /// </summary>
    public string Name {
        get;
        init;
    } = String.Empty;

    /// <summary>
    /// Währung
    /// </summary>
    public Currency Currency {
        get;
        init;
    } = Currency.EUR;

    /// <summary>
    /// Nachrichtliche Informationen
    /// </summary>
    public Informations Informations {
        get;
        init;
    } = new();

    /// <summary>
    /// Besitzer
    /// </summary>
    public Owner Owner {
        get;
        init;
    } = new();

}
