
namespace Gschwind.Lighthouse.Example.Models.Data;

/// <summary>
/// Wohngebäude-Versicherung
/// </summary>
public record BuildingInsurance : PropertyInsurance {

    /// <summary>
    /// Neuwert
    /// </summary>
    public bool OriginalValue {
        get;
        init;
    }

    /// <summary>
    /// Versicherungsort
    /// </summary>
    public string? InsuranceLocation {
        get;
        init;
    }

    /// <summary>
    /// Garage
    /// </summary>
    public bool Garage {
        get;
        init;
    }

    /// <summary>
    /// Ständig bewohnt
    /// </summary>
    public bool ConstantlyInhabited {
        get;
        init;
    }

    /// <summary>
    /// Haustyp
    /// </summary>
    public int HouseType {
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
