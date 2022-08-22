using System.Reflection;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace Gschwind.Lighthouse.Example.Serialization {

    /// <summary>
    /// Implementiert einen <see cref="IContractResolver"/>, der Konventionen der Lighthouse API anwendet
    /// </summary>
    internal class LighthouseContractResolver : CamelCasePropertyNamesContractResolver {

        class TypeValueProvider : IValueProvider {

            /// <inheritdoc/>
            public object? GetValue(object target) =>
                target switch {
                    {} => target.GetType().Name,
                    _ => null
                };

            /// <inheritdoc/>
            public void SetValue(object target, object? value) {
                // Automatischer Wert
            }

        }

        /// <inheritdoc/>
        protected override JsonObjectContract CreateObjectContract(Type objectType) {
            var baseContract = base.CreateObjectContract(objectType);

            if (DerivesFromAbstract(objectType) && !baseContract.Properties.Contains("type"))
                baseContract.Properties.Add(new() {
                    PropertyName = "type",
                    PropertyType = typeof(string),
                    Readable = true,
                    Writable = true,
                    ValueProvider = new TypeValueProvider(),
                    // Notwendig für Swashbuckle
                    DeclaringType = objectType,
                    UnderlyingName = "Type",
                });

            return baseContract;
        }

        /// <inheritdoc/>
        protected override JsonConverter? ResolveContractConverter(Type objectType) {
            if (objectType.IsClass && objectType.IsAbstract) {
                var converterType = typeof(PolymorphicObjectConverter<>).MakeGenericType(objectType);
                if (Activator.CreateInstance(converterType) is JsonConverter converter)
                    return converter;
            }

            return base.ResolveContractConverter(objectType);
        }

        /// <inheritdoc/>
        protected override JsonProperty CreateProperty(MemberInfo member, MemberSerialization memberSerialization) {
            var property = base.CreateProperty(member, memberSerialization);

            var publicGetterPrivateSetter =
                property.Readable &&
                !property.Writable &&
                member is PropertyInfo { SetMethod: { IsPrivate: true } };

            // Werte in Eigenschaften mit privaten Settern deserialisieren
            property.Writable |= publicGetterPrivateSetter;

            return property;
        }

        static bool DerivesFromAbstract(Type? type) {
            type = type?.BaseType;
            while (type != null) {
                if (type.IsClass && type.IsAbstract)
                    return true;
                type = type.BaseType;
            }

            return false;
        }

    }

}
