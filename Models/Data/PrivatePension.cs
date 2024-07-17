namespace Gschwind.Lighthouse.Example.Models.Data;

/// <summary>
/// Private Altersvorsorge
/// </summary>
public abstract record PrivatePension : EndowmentInsurance {

    /// <summary>
    /// Sonderzahlungen
    /// </summary>
    public ICollection<DateValue> AdditionalPremium {
        get;
        init;
    } = [];

    /// <summary>
    /// Rentengarantiezeit in Jahren
    /// </summary>
    public int PensionGaranteeYears {
        get;
        init;
    }

    /// <summary>
    /// Ist die Rente befristet?
    /// </summary>
    public bool IsPensionLimitated {
        get;
        init;
    }

    /// <summary>
    /// Datum der Rentenbefristung
    /// </summary>
    public DateTime PensionLimitation {
        get;
        init;
    } = new(2027, 12, 31);

    /// <summary>
    /// Witwenrente
    /// </summary>
    public double WidowsPension {
        get;
        init;
    }

    /// <summary>
    /// Waisenrente
    /// </summary>
    public double OrphansPension {
        get;
        init;
    }

    /// <summary>
    /// Waisenrente wird gezahlt bis Alter
    /// </summary>
    public int OrphansPensionAge {
        get;
        init;
    } = 27;

    /// <summary>
    /// Einzahlungen bis zum Leistungszeitraum
    /// </summary>
    public bool PremiumUntilPayout {
        get;
        init;
    } = true;

    /// <summary>
    /// Beitragszeit
    /// </summary>
    public int PremiumYears {
        get;
        init;
    } = 12;

    /// <summary>
    /// Soll die Leistung automatisch berechnet werden?
    /// </summary>
    public bool CalculatePayout {
        get;
        init;
    } = true;

    /// <summary>
    /// Parameter zur automatischen Berechnung der Kapitalauszahlung oder Rente
    /// </summary>
    public CalculationParameter CalculationParameter {
        get;
        init;
    } = new();

    /// <summary>
    /// Rückkaufwerte
    /// </summary>
    public ICollection<DateValue> RepurchaseValues {
        get;
        init;
    } = [];

}
