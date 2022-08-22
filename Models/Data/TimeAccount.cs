namespace Gschwind.Lighthouse.Example.Models.Data;

/// <summary>
/// Zeitwertkonto
/// </summary>
public record TimeAccount : CashFlowBase {

    /// <summary>
    /// Risikostufe
    /// </summary>
    public RiskLevel RiskLevel {
        get;
        init;
    }

    /// <summary>
    /// aus Gehaltsumwandlung
    /// </summary>
    public bool ConvertingIncome {
        get;
        init;
    } = true;

    /// <summary>
    /// Zinssatz
    /// </summary>
    public ICollection<DateValue> InterestRate {
        get;
        init;
    } = new List<DateValue>();

    /// <summary>
    /// Auszahlungen
    /// </summary>
    public CashFlows Withdrawals {
        get;
        init;
    } = new();

    /// <summary>
    /// Zahlung
    /// </summary>
    public CashFlows Payment {
        get;
        init;
    } = new();

}
