namespace Gschwind.Lighthouse.Example.Models.Data;

/// <summary>
/// Risiko-Lebensversicherung
/// </summary>
public record TermLifeInsurance : PersonalInsurance {

    /// <summary>
    /// Todesfallleistung
    /// </summary>
    public ICollection<DateValue> DeathBenefit {
        get;
        init;
    } = [];

    /// <summary>
    /// Begünstiger im Todesfall
    /// </summary>
    public Guid Beneficiary {
        get;
        init;
    } = Guid.Empty;

    /// <summary>
    /// Versicherungsdauer
    /// </summary>
    public int PremiumYears {
        get;
        init;
    } = 12;

    /// <summary>
    /// Erzeugt eine neue Instanz der <see cref="TermLifeInsurance"/>-Klasse
    /// </summary>
    public TermLifeInsurance() =>
        Premium = Premium with { Period = Period.Yearly };

}
