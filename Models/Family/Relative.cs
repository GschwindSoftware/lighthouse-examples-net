namespace Gschwind.Lighthouse.Example.Models.Family;

/// <summary>
/// Ein diverser Verwandter des Kunden innerhalb einer `Familie`
/// </summary>
public record Relative : FamilyMember {

    /// <summary>
    /// Beschreibt die Beziehung der Person zum Kunden
    /// </summary>
    public string Description {
        get;
        private set;
    } = "Entfernter Verwandter";

}
