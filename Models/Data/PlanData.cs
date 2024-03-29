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

}
