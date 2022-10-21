using System.Reflection;

namespace Gschwind.Lighthouse.Example.Serialization;

/// <summary>
/// Bestimmt die Id des OpenAPI Schemas des Typens.
/// </summary>
/// <remarks>
/// Standardmäßig wird der Typname als Id gewählt. Dieses Verhalten kann mit dem Attribut überschrieben werden.
/// </remarks>
/// <seealso href="https://swagger.io/docs/specification/basic-structure/"/>
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Interface | AttributeTargets.Struct | AttributeTargets.Enum)]
public class SchemaIdAttribute : Attribute {

    /// <summary>
    /// Ruft Schema-Id ab.
    /// </summary>
    public string Id { get; }

    /// <summary>
    /// Erzeugt ein neues Objekt der <see cref="SchemaIdAttribute"/>-Klasse.
    /// </summary>
    /// <param name="id">Die Schema-Id</param>
    public SchemaIdAttribute(string id) => Id = id;

    /// <summary>
    /// Wendet <see cref="SchemaIdAttribute"/> an.
    /// </summary>
    /// <param name="t">Der Typ, dessen Schema benamt werden soll.</param>
    /// <returns>Der Name des Schemas.</returns>
    public static string Apply(Type t) =>
        t is { GenericTypeArguments: { Length: 1 } } ?
            $"{Name(t)}Of{Apply(GetGenericArgument(t))}" : Name(t);

    static string Name(Type t) =>
        SanitizeGenericName(t.GetCustomAttribute<SchemaIdAttribute>() is { Id: var id } a ? id : t.Name);

    static string SanitizeGenericName(string name) {
        if (name.Contains('`'))
            name = name[..name.IndexOf('`')];

        return name;
    }

    static Type GetGenericArgument(Type type) =>
        type.GenericTypeArguments.Single();

}
