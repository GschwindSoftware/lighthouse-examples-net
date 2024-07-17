namespace Gschwind.Lighthouse.Example.Models.Data;

/// <summary>
/// Anlageklasse
/// </summary>
public record AssetClass : PlanData {

    /// <summary>
    /// Ausschüttungen
    /// </summary>
    public ICollection<PercentValue> Dividends {
        get;
        init;
    } = [];

    /// <summary>
    /// Wertsteigerungen
    /// </summary>
    public ICollection<PercentValue> Appreciations {
        get;
        init;
    } = [];

    /// <summary>
    /// Muss Wertsteigerung und Dividende versteuert werden?
    /// </summary>
    public bool IsTaxable {
        get;
        init;
    } = true;

    /// <summary>
    /// Wiederanlage der Gewinne
    /// </summary>
    public bool ReinvestDividends {
        get;
        init;
    }

    /// <summary>
    /// Die Regionen des Wertpapieres
    /// </summary>
    public ICollection<Region> Regions {
        get;
        init;
    } = [];

    /// <summary>
    /// Die Branchen des Wertpapieres
    /// </summary>
    public ICollection<Industry> Industries {
        get;
        init;
    } = [];

    /// <summary>
    /// Die Instrumente des Wertpapieres.
    /// </summary>
    public ICollection<Instrument> Instruments {
        get;
        set;
    } = [];

    /// <summary>
    /// Der Typ des Wertpapieres
    /// </summary>
    public SecurityType SecurityType {
        get;
        init;
    } = SecurityType.Stock;

    /// <summary>
    /// Prozentsätze am Gesamt-Depot
    /// </summary>
    public ICollection<PercentValue> Rates {
        get;
        init;
    } = [];

    /// <summary>
    /// Risikostufe
    /// </summary>
    public RiskLevel RiskLevel {
        get;
        init;
    } = RiskLevel.NotCritical;

    /// <summary>
    /// Rating
    /// </summary>
    public string? Rating {
        get;
        init;
    }

}
