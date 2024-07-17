namespace Gschwind.Lighthouse.Example.Models.Data;

/// <summary>
/// Basisklasse für Immobilien
/// </summary>
public abstract record PropertyBase : RealValue {

    /// <summary>
    /// Standort
    /// </summary>
    public string? Location {
        get;
        init;
    }

    /// <summary>
    /// Baujahr
    /// </summary>
    public int BuildYear {
        get;
        init;
    } = DateTime.Now.Year;

    /// <summary>
    /// Grundstückkosten
    /// </summary>
    public double LandCosts {
        get;
        init;
    }

    /// <summary>
    /// Kaufnebenkosten
    /// </summary>
    public double PurchaseCosts {
        get;
        init;
    }

    /// <summary>
    /// Gewinn automatisch aus den Details berechnet
    /// </summary>
    public bool ComputeProfit {
        get;
        init;
    }

    /// <summary>
    /// Manuelle Gewinneingabe, falls ComputeProfit = false
    /// </summary>
    public CashFlows Profit {
        get;
        init;
    } = new();

    /// <summary>
    /// Betriebskosten
    /// </summary>
    public ICollection<OperatingCost> OperatingCosts {
        get;
        init;
    } = new List<OperatingCost>();

    /// <summary>
    /// Rücklagen
    /// </summary>
    public ICollection<MaintenanceReserve> MaintenanceReserves {
        get;
        init;
    } = new List<MaintenanceReserve>();

    /// <summary>
    /// Nießbrauch
    /// </summary>
    public ICollection<DateValue> Usufruct {
        get;
        init;
    } = new List<DateValue>();

    /// <summary>
    /// Steuerliche Bewertung der Immobilie
    /// </summary>
    public PropertyValuation PropertyValuation {
        get;
        init;
    } = new();

    /// <summary>
    /// Wohnfläche
    /// </summary>
    public int LivingArea {
        get;
        init;
    }

    /// <summary>
    /// Sanierungen
    /// </summary>
    public ICollection<Renovation> Renovations {
        get;
        set;
    } = new List<Renovation>();

}
