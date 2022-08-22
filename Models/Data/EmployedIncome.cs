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
    public int NumberOfPayments {
        get;
        init;
    } = 12;

    /// <summary>
    /// Dienstwagen
    /// </summary>
    public ICollection<CompanyCar> CompanyCars {
        get;
        init;
    } = new List<CompanyCar>();

    /// <summary>
    /// Bonuszahlungen
    /// </summary>
    public ICollection<Bonus> Bonuses {
        get;
        init;
    } = new List<Bonus>();

    /// <summary>
    /// Geldwerter Vorteile
    /// </summary>
    public ICollection<MonetaryAdvantage> MonetaryAdvantages {
        get;
        init;
    } = new List<MonetaryAdvantage>();

    /// <summary>
    /// Erzeugt eine neue Instanz der <see cref="EmployedIncome"/>-Klasse
    /// </summary>
    public EmployedIncome() {
        CashFlows = CashFlows with { Period = Period.Monthly };
        Termination = Termination with { Type = MomentType.AtRetirement };
    }

}
