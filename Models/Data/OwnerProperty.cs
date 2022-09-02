namespace Gschwind.Lighthouse.Example.Models.Data;

/// <summary>
/// Eigengenutzte Immobilie
/// </summary>
public record OwnerProperty : PropertyBase {

    /// <summary>
    /// Haupt-Familienwohnheim
    /// </summary>
    public bool MainFamilyResidential {
        get;
        init;
    }

}
