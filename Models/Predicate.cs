using Newtonsoft.Json;

namespace Gschwind.Lighthouse.Example.Models;

/// <summary>
/// Ein <see cref="Term"/>, der die Eigenschaft eines Objekt vergleicht
/// </summary>
/// <param name="Property">Der Namen der Eigenschaft, die verglichen werden soll</param>
/// <param name="Operator">Der Vergleichsoperator</param>
/// <param name="Value">Der Wert, mit dem verglichen werden soll</param>
public record Predicate(
    string Property,
    [property: JsonProperty("op")]
    RelationalOperator Operator,
    object? Value
) : Term();
