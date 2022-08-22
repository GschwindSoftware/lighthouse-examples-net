using System.Diagnostics.CodeAnalysis;
using System.Linq.Expressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Gschwind.Lighthouse.Example.Serialization {

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

        readonly static IReadOnlyDictionary<string, Func<T>> _factories = GenerateFactories();

        /// <inheritdoc/>
        public override bool CanWrite => false;

        static IReadOnlyDictionary<string, Func<T>> GenerateFactories() {
            // Eine Factorymethode für einen Typen kompilieren
            static Func<T> createFactoryMethod(Type concreteType) {
                var ctor = concreteType.GetConstructor(Array.Empty<Type>())!;

                return Expression
                    .Lambda<Func<T>>(Expression.New(ctor))
                    .Compile();
            }

            return typeof(T)
                .Assembly
                .GetTypes()
                .Where(t =>
                    !t.IsAbstract &&
                    typeof(T).IsAssignableFrom(t) &&
                    t.GetConstructor(Array.Empty<Type>()) != null
                )
                .ToDictionary(
                    t => t.Name,
                    t => createFactoryMethod(t),
                    StringComparer.OrdinalIgnoreCase
                );
        }

        /// <inheritdoc/>
        public override T ReadJson(JsonReader reader, Type objectType, [AllowNull] T existingValue, bool hasExistingValue, JsonSerializer serializer) {
            if (JObject.ReadFrom(reader) is not JObject jObj)
                throw new JsonReaderException();

            if (jObj.Property("type") is not { Value: JValue { Value: string { Length: > 0  } discriminator } })
                throw new JsonReaderException();

            if (!_factories.TryGetValue(discriminator, out var createObject))
                throw new TypeAccessException();

            var obj = createObject();
            using var jr = jObj.CreateReader();
            serializer.Populate(jr, obj!);

            return obj;
        }

        /// <inheritdoc/>
        public override void WriteJson(JsonWriter writer, [AllowNull] T value, JsonSerializer serializer) =>
            throw new NotSupportedException();

    }

}
