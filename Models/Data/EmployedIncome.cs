namespace Gschwind.Lighthouse.Example.Models.Data;

/// <summary>
/// Einkunft aus nichtselbständiger Arbeit
/// </summary>
public record EmployedIncome : CashFlowBase {

    /// <summary>
    /// Sozialversicherungspflichtig
    /// </summary>
    public bool IsStateInsuranceDuty {
        get;
        init;
    } = true;

    /// <summary>
    /// Anzahl Monatsgehälter
    /// </summary>
    public PaymentsPerYear PaymentsPerYear {
        get;
        init;
    } = PaymentsPerYear.Twelve;

    /// <summary>
    /// Dienstwagen
    /// </summary>
    public ICollection<CompanyCar> CompanyCars {
        get;
        init;
    } = [];

    /// <summary>
    /// Bonuszahlungen
    /// </summary>
    public ICollection<Bonus> Bonuses {
        get;
        init;
    } = [];

    /// <summary>
    /// Geldwerter Vorteile
    /// </summary>
    public ICollection<MonetaryAdvantage> MonetaryAdvantages {
        get;
        init;
    } = [];

    /// <summary>
    /// Erzeugt eine neue Instanz der <see cref="EmployedIncome"/>-Klasse
    /// </summary>
    public EmployedIncome() {
        CashFlows = CashFlows with { Period = Period.Monthly };
        Termination = Termination with { Type = MomentType.AtRetirement };
    }

}
