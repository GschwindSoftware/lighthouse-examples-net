namespace Gschwind.Lighthouse.Example.Models.Family;

/// <summary>
/// Der Typ der Beziehung zwischen zwei Familienmigliedern
/// </summary>
public enum RelationshipType {
    /// <summary>
    /// Familienmitglied ist Elternteil
    /// </summary>
    Parent,
    /// <summary>
    /// Familienmitglied ist Kind
    /// </summary>
    Child,
    /// <summary>
    /// Familienmitglied ist Partner
    /// </summary>
    Partner
}
