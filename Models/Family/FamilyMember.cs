namespace Gschwind.Lighthouse.Example.Models.Family;

/// <summary>
/// Einer der möglichen Einträge von Familienmitgliedern innerhalb einer Familie
/// </summary>
public abstract record FamilyMember {

    /// <summary>
    /// Die eindeutige ID innerhalb des Familienbaums, die verwendet wird, um auf das Familienmitglied in unterschiedlichen Endpunkten zu verweisen
    /// </summary>
    public Guid Id {
        get;
        init;
    } = Guid.NewGuid();

    /// <summary>
    /// Gibt das Geschlecht der Person an
    /// </summary>
    public Gender Gender {
        get;
        init;
    } = Gender.Male;

    /// <summary>
    /// Gibt den Titel der Person an
    /// </summary>
    public string? Title {
        get;
        init;
    }

    /// <summary>
    /// Der Vorname der Person
    /// </summary>
    public string? FirstName {
        get;
        init;
    }

    /// <summary>
    /// Der Nachname der Person
    /// </summary>
    public string? LastName {
        get;
        init;
    }

    /// <summary>
    /// Der Geburtstag der Person
    /// </summary>
    public DateTime Birthday {
        get;
        init;
    } = new(1980, 1, 1);

    /// <summary>
    /// Gibt an, ob die Person verstorben ist
    /// </summary>
    public bool IsDead {
        get;
        init;
    }

    /// <summary>
    /// Gibt an, ob ein Pflichtteilsverzicht vorliegt
    /// </summary>
    public bool MandatoryPartialWaiver {
        get;
        init;
    }

    /// <summary>
    /// Gibt an, ob die Person Haupt-Familienwohnheim bewohnt
    /// </summary>
    public bool LivesInFamilyResidence {
        get;
        init;
    }

    /// <summary>
    /// Gibt eine <see cref="Relationship"/> zurück, in der dieses <see cref="FamilyMember"/> Kind des
    /// übergebenen <see cref="FamilyMember"/> ist
    /// </summary>
    /// <param name="parent">Der Elternteil</param>
    /// <returns>Die erzeugte <see cref="Relationship"/></returns>
    public Relationship IsChildOf(FamilyMember parent) =>
        new() {
            FamilyMemberId = Id,
            Type = RelationshipType.Child,
            RelatedFamilyMemberId = parent.Id
        };

    /// <summary>
    /// Gibt eine <see cref="Relationship"/> zurück, in der dieses <see cref="FamilyMember"/> Kind der übergebenen
    /// <see cref="FamilyMember"/> ist
    /// </summary>
    /// <param name="parent1">Der erste Elternteil</param>
    /// <param name="parent2">Der zweite Elternteil</param>
    /// <returns>Die erzeugte <see cref="Relationship"/></returns>
    public IEnumerable<Relationship> IsChildOf(FamilyMember parent1, FamilyMember parent2) =>
        new[] { IsChildOf(parent1), IsChildOf(parent2) };

    /// <summary>
    /// Gibt eine <see cref="Relationship"/> zurück, in der dieses <see cref="FamilyMember"/> Lebenspartner des
    /// übergebenen <see cref="FamilyMember"/> ist
    /// </summary>
    /// <param name="partner">Der Lebenspartner</param>
    /// <returns>Die erzeugte <see cref="Relationship"/></returns>
    public Relationship IsPartnerOf(FamilyMember partner) =>
        new() {
            FamilyMemberId = Id,
            Type = RelationshipType.Partner,
            RelatedFamilyMemberId = partner.Id
        };

    /// <summary>
    /// Gibt eine <see cref="Relationship"/> zurück, in der dieses <see cref="FamilyMember"/> Elternteil des
    /// übergebenen <see cref="FamilyMember"/> ist
    /// </summary>
    /// <param name="child">Das Kind</param>
    /// <returns>Die erzeugte <see cref="Relationship"/></returns>
    public Relationship IsParentOf(FamilyMember child) =>
        new() {
            FamilyMemberId = Id,
            Type = RelationshipType.Parent,
            RelatedFamilyMemberId = child.Id
        };

}
