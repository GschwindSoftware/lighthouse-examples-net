using Gschwind.Lighthouse.Example.Serialization;

namespace Gschwind.Lighthouse.Example.Models.Family;

/// <summary>
/// Der Kunde innerhalb einer Familie. Jede Familie darf genau einen Kunden beinhalten
/// </summary>
[SchemaId("Customer")]
public record Client : ClientOrPartner {

    /// <summary>
    /// Gibt an, ob der Partner des Kunden der Ehepartner des Kunden ist
    /// </summary>
    public bool IsMarried {
        get;
        init;
    } = true;

    /// <summary>
    /// Gibt an, ob Kunde und Partner zusammen veranlagt sind
    /// </summary>
    public bool JointTaxation {
        get;
        init;
    } = true;

}
