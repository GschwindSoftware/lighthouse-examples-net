namespace Gschwind.Lighthouse.Example.Models.Data;

/// <summary>
/// Bausparvertrag
/// </summary>
public record BuildingLoanContract : SavingDeposit {

    /// <summary>
    /// Bausparsumme
    /// </summary>
    public double ContractSum {
        get;
        init;
    }

    /// <summary>
    /// Mindestguthaben in % der Bausparsumme
    /// </summary>
    public double MinimumBalance {
        get;
        init;
    } = 50;

    /// <summary>
    /// Abschlusskosten in % der Bausparsumme
    /// </summary>
    public double AcquisitionCosts {
        get;
        init;
    } = 1;

    /// <summary>
    /// Kontoführungskosten
    /// </summary>
    public CashFlows Fees {
        get;
        init;
    } = new() { Period = Period.Yearly };

    /// <summary>
    /// Sparende
    /// </summary>
    public SavingEnd SavingEnd {
        get;
        init;
    } = new();

    /// <summary>
    /// Auszahlung des Bonus
    /// </summary>
    public BonusType BonusType {
        get;
        init;
    }

    /// <summary>
    /// Bonus in % der Bausparsumme
    /// </summary>
    public double Bonus {
        get;
        init;
    }

}
