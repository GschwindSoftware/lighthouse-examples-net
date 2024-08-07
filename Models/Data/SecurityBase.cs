namespace Gschwind.Lighthouse.Example.Models.Data;

/// <summary>
/// Wertpapierbasis
/// </summary>
public abstract record SecurityBase : SelfContainedPlanData {

    /// <summary>
    /// Name des Depots
    /// </summary>
    public string DepotName {
        get;
        init;
    } = String.Empty;

    /// <summary>
    /// Der Typ des Wertpapieres
    /// </summary>
    public SecurityType SecurityType {
        get;
        init;
    } = SecurityType.Stock;

    /// <summary>
    /// Die ISIN-Nummer des Wertpapieres
    /// </summary>
    public string Isin {
        get;
        init;
    } = String.Empty;

    /// <summary>
    /// Wertstellungsdatum
    /// </summary>
    public DateTime ValueDate {
        get;
        init;
    } = DateTime.Now.Date;

    /// <summary>
    /// Stückzahl bei Aktien / Nominalbetrag bei Anleihen
    /// </summary>
    public double Quantity {
        get;
        init;
    }

    /// <summary>
    /// Kurs
    /// </summary>
    public double Quote {
        get;
        init;
    }

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

    /// <summary>
    /// Die Regionen des Wertpapieres
    /// </summary>
    public ICollection<Region> Regions {
        get;
        init;
    } = [];

    /// <summary>
    /// Der Industriesektor des Wertpapieres
    /// </summary>
    public ICollection<Industry> Industries {
        get;
        init;
    } = [];

    /// <summary>
    /// Der Instrumente des Wertpapieres.
    /// </summary>
    public ICollection<Instrument> Instruments {
        get;
        set;
    } = [];

    /// <summary>
    /// Ordern
    /// </summary>
    public ICollection<SecurityOrder> Orders {
        get;
        init;
    } = [];

    /// <summary>
    /// Bisherige Dividenden
    /// </summary>
    public ICollection<DateValue> Earnings {
        get;
        init;
    } = [];

    /// <summary>
    /// Verkauf
    /// </summary>
    public Selling Selling {
        get;
        init;
    } = new();

}
