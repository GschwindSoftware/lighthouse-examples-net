namespace Gschwind.Lighthouse.Example.Models.Data;

/// <summary>
/// Hausratversicherung
/// </summary>
public record HouseholdInsurance : PropertyInsurance {

    /// <summary>
    /// Glasversicherung vorhanden?
    /// </summary>
    public bool GlassInsurance {
        get;
        init;
    }

    /// <summary>
    /// Elementarversicherung vorhanden?
    /// </summary>
    public bool ElementaryInsurance {
        get;
        init;
    }

    /// <summary>
    /// Unterversichert?
    /// </summary>
    public bool UnderInsurance {
        get;
        init;
    }

    /// <summary>
    /// Wohnfläche
    /// </summary>
    public int LivingArea {
        get;
        init;
    }

}
