namespace Gschwind.Lighthouse.Example.Models.Family;

/// <summary>
/// Der Stammbaum eines Kunden
/// </summary>
public record Family {

    /// <summary>
    /// Auflistung der Familienmitglieder
    /// </summary>
    public ICollection<FamilyMember> Members {
        get;
        init;
    } = new List<FamilyMember>();

    /// <summary>
    /// Auflistung der Beziehungen zwischen Familienmitgliedern
    /// </summary>
    public ICollection<Relationship> Relationships {
        get;
        init;
    } = new List<Relationship>();

}
