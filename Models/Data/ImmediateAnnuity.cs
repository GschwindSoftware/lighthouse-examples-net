namespace Gschwind.Lighthouse.Example.Models.Data;

/// <summary>
/// Sofortrente
/// </summary>
public record ImmediateAnnuity : SelfContainedPlanData {

    /// <summary>
    /// Versicherte Person
    /// </summary>
    public Guid InsuredPerson {
        get;
        init;
    } = Guid.Empty;

    /// <summary>
    /// Name der Versicherungsgesellschaft
    /// </summary>
    public string InsuranceCompany {
        get;
        init;
    } = String.Empty;

    /// <summary>
    /// Vertragsnummer
    /// </summary>
    public string ContractNumber {
        get;
        init;
    } = String.Empty;

    /// <summary>
    /// Versicherungsbeginn
    /// </summary>
    public DateTime InceptionDate {
        get;
        init;
    } = new(DateTime.Now.Year, 1, 1);

    /// <summary>
    /// Risikostufe
    /// </summary>
    public RiskLevel RiskLevel {
        get;
        init;
    } = RiskLevel.None;

    /// <summary>
    /// Einmalzahlung
    /// </summary>
    public double SinglePayment {
        get;
        init;
    }

    /// <summary>
    /// Monatliche Rente
    /// </summary>
    public double Pension {
        get;
        init;
    }

    /// <summary>
    /// Rentensteigerung
    /// </summary>
    public double PensionIncrease {
        get;
        init;
    }

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
    /// Art der Leistungen im Todesfall
    /// </summary>
    public DeathPaymentType DeathPaymentType {
        get;
        init;
    } = DeathPaymentType.None;

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

}
