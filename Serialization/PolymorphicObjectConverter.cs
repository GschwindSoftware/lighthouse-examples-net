using System.Diagnostics.CodeAnalysis;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Gschwind.Lighthouse.Example.Serialization;

/// <summary>
/// Implementiert einen <see cref="JsonConverter"/>, der je nach Wert der Eigenschaft <c>type</c> abgeleitete Objekte
/// einer abstrakten Klasse erzeugt
/// </summary>
/// <remarks>
/// Der Wert von <c>type</c> entspricht hier dem Namen der konkreten Klasse. Konkrete Klassen dürfen mit ihren Namen nicht
/// kollidieren und einen Standardkonstruktor besitzen
/// </remarks>
/// <typeparam name="T">Der abstrakte Basistyp.</typeparam>
internal class PolymorphicObjectConverter<T> : JsonConverter<T> {

    readonly static IReadOnlyDictionary<string, Type> _concreteTypes = typeof(T)
        .Assembly
        .GetTypes()
        .Where(t =>
            !t.IsAbstract &&
            typeof(T).IsAssignableFrom(t)
        )
        .ToDictionary(
            t => t.Name,
            t => t,
            StringComparer.OrdinalIgnoreCase
        );

    /// <inheritdoc/>
    public override bool CanWrite => false;

    /// <inheritdoc/>
    public override T ReadJson(JsonReader reader, Type objectType, [AllowNull] T existingValue, bool hasExistingValue, JsonSerializer serializer) {
        if (JObject.ReadFrom(reader) is not JObject jObj)
            throw new JsonReaderException();

        if (jObj.Property("type") is not { Value: JValue { Value: string { Length: > 0  } discriminator } })
            throw new JsonReaderException();

        if (!_concreteTypes.TryGetValue(discriminator, out var concreteType))
            throw new TypeAccessException();

        return (T)jObj.ToObject(concreteType, serializer)!;
    }

    /// <inheritdoc/>
    public override void WriteJson(JsonWriter writer, [AllowNull] T value, JsonSerializer serializer) =>
        throw new NotSupportedException();

}
