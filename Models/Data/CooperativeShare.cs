namespace Gschwind.Lighthouse.Example.Models.Data;

/// <summary>
/// Genossenschaftsanteil
/// </summary>
public record CooperativeShare : SecurityInvestment {

    /// <summary>
    /// Risikostufe
    /// </summary>
    public RiskLevel RiskLevel {
        get;
        init;
    } = RiskLevel.NotCritical;

    /// <summary>
    /// Zeitraum
    /// </summary>
    public TimePeriod TimePeriod {
        get;
        init;
    } = new();

    /// <summary>
    /// Wertstellung
    /// </summary>
    public DateTime ValueDate {
        get;
        init;
    } = DateTime.Now.Date;

    /// <summary>
    /// Anzahl Anteile
    /// </summary>
    public double Quantity {
        get;
        init;
    }

    /// <summary>
    /// Preis pro Anteil
    /// </summary>
    public double Price {
        get;
        init;
    }

    /// <summary>
    /// Bestand oder Neuanlage
    /// </summary>
    public InvestmentType InvestmentType {
        get;
        init;
    }

    /// <summary>
    /// Ausschüttungen in Prozent
    /// </summary>
    public ICollection<PercentValue> Dividend {
        get;
        init;
    } = [];

    /// <summary>
    /// Wertsteigerung
    /// </summary>
    public double Depreciation {
        get;
        init;
    }

}
