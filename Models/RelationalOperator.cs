using System.Runtime.Serialization;

namespace Gschwind.Lighthouse.Example.Models;

/// <summary>
/// Der Vergleichsoperator eines <see cref="Predicate"/>
/// </summary>
public enum RelationalOperator {
    /// <summary>
    /// Gleichhheit
    /// </summary>
    [EnumMember(Value="eq")]
    Equals,
    /// <summary>
    /// Ungleichheit
    /// </summary>
    [EnumMember(Value="ne")]
    NotEquals,
    /// <summary>
    /// Anzahl Elemente / Zeichen
    /// </summary>
    [EnumMember(Value="ct")]
    Count,
    /// <summary>
    /// Teilmenge
    /// </summary>
    [EnumMember(Value="in")]
    Contains,
    /// <summary>
    /// Größer
    /// </summary>
    [EnumMember(Value="gt")]
    GreaterThan,
    /// <summary>
    /// Kleiner
    /// </summary>
    [EnumMember(Value="lt")]
    LessThan,
    /// <summary>
    /// Größer gleich
    /// </summary>
    [EnumMember(Value="ge")]
    GreaterEquals,
    /// <summary>
    /// Kleiner gleich
    /// </summary>
    [EnumMember(Value="le")]
    LessEquals,
    /// <summary>
    /// Liste / Zeichenfolge nicht leer
    /// </summary>
    [EnumMember(Value="nm")]
    NotEmpty
}
