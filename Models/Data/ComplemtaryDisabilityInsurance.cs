namespace Gschwind.Lighthouse.Example.Models.Data;

/// <summary>
/// Abfindung
/// </summary>
/// <summary>
/// Berufsunfähigkeitszusatzversicherung
/// </summary>
public record ComplementaryDisabilityInsurance {

    /// <summary>
    /// Ende der Versicherung
    /// </summary>
    public Moment InsuranceEnd {
        get;
        init;
    } = new();

    /// <summary>
    /// Ende der Leistungen
    /// </summary>
    public Moment PremiumEnd {
        get;
        init;
    } = new();

    /// <summary>
    /// Leistung erfolgt nach x Wochen
    /// </summary>
    public int PremiumWeeks {
        get;
        init;
    }

    /// <summary>
    /// Rente
    /// </summary>
    public double Pension {
        get;
        init;
    }

    /// <summary>
    /// Rentensteigerung
    /// </summary>
    public double Increase {
        get;
        init;
    }

    /// <summary>
    /// Weitere Beitragszahlungen
    /// </summary>
    public FurtherPremiumType FurtherPremiumType {
        get;
        init;
    } = FurtherPremiumType.Continue;

    /// <summary>
    /// Reduzierte Rente
    /// </summary>
    public double ReducedPension {
        get;
        init;
    }

    /// <summary>
    /// Reduzierte Kapitalleistung
    /// </summary>
    public double ReducedCapitalPayment {
        get;
        init;
    }

}
