using Gschwind.Lighthouse.Example.Models.Data;
using Gschwind.Lighthouse.Example.Models.Plans.Settings;

namespace Gschwind.Lighthouse.Example.Models.Plans;

/// <summary>
/// Stellt die Daten eines Finanzplans bereit
/// </summary>
public record Plan {

    /// <summary>
    /// Der eindeutige Schlüssel des Plans
    /// </summary>
    public int Id {
        get;
        private set;
    }

    /// <summary>
    /// Die Einstellungen des Plans
    /// </summary>
    public PlanSettings? Settings {
        get;
        init;
    }

    /// <summary>
    /// Der Familienstammbaum
    /// </summary>
    public Family.Family? Family {
        get;
        init;
    }

    /// <summary>
    /// Die Sammlung der Vorgänge
    /// </summary>
    public ICollection<PlanData> Finances {
        get;
        init;
    } = new List<PlanData>();

}
