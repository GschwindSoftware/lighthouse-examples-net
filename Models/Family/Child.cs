namespace Gschwind.Lighthouse.Example.Models.Family;

/// <summary>
/// Ein Kind des Kunden / Partners innerhalb der Familie
/// </summary>
public record Child : FamilyMember {

    /// <summary>
    /// Gibt an, wer den Kinderfreibetrag erhält
    /// </summary>
    public ChildAllowancePerson ChildAllowancePerson {
        get;
        init;
    } = ChildAllowancePerson.Client;

    /// <summary>
    /// Das Alter in Jahren, bis zu dem die Eltern des Kindes Anspruch auf das Kindergeld haben
    /// </summary>
    public int ChildAllowanceAge {
        get;
        init;
    } = 18;

    /// <summary>
    /// Gibt an, bis zum wievielten Lebensjahr das Kind im Haushalt lebt
    /// </summary>
    public int HouseholdResidecy {
        get;
        init;
    } = 18;

    /// <summary>
    /// Zuordnung eines Kindes zu einem Riestervertrag
    /// </summary>
    public RiesterChildAssignment RiesterChildAssignment {
        get;
        init;
    } = RiesterChildAssignment.Automatic;

}
