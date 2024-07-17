namespace Gschwind.Lighthouse.Example.Models.Data;

/// <summary>
/// Betriebliche Kapitalversicherung
/// </summary>
public abstract record CompanyCapitalInsurance : CompanyPension {

    /// <summary>
    /// Versicherte Person
    /// </summary>
    public Guid InsuredPerson {
        get;
        init;
    } = Guid.Empty;

    /// <summary>
    /// Sonderzahlungen
    /// </summary>
    public ICollection<DateValue> AdditionalPremium {
        get;
        init;
    } = [];

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

    /// <summary>
    /// Weitere Leistungen
    /// </summary>
    public ICollection<DateValue> AdditionalPayments {
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
    /// Art der Leistungen im Todesfall
    /// </summary>
    public DeathPaymentType DeathPaymentType {
        get;
        init;
    } = DeathPaymentType.None;

    /// <summary>
    /// Todesfallleistung
    /// </summary>
    public ICollection<DateValue> DeathBenefit {
        get;
        init;
    } = [];

    /// <summary>
    /// 1. Begünstiger im Todesfall
    /// </summary>
    public Guid Beneficiary1 {
        get;
        init;
    } = Guid.Empty;

    /// <summary>
    /// 2. Begünstiger im Todesfall
    /// </summary>
    public Guid Beneficiary2 {
        get;
        init;
    } = Guid.Empty;

    /// <summary>
    /// 3. Begünstiger im Todesfall
    /// </summary>
    public Guid Beneficiary3 {
        get;
        init;
    } = Guid.Empty;

    /// <summary>
    /// 4. Begünstiger im Todesfall
    /// </summary>
    public Guid Beneficiary4 {
        get;
        init;
    } = Guid.Empty;

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

}
