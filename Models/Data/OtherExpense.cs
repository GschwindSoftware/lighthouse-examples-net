namespace Gschwind.Lighthouse.Example.Models.Data;

/// <summary>
/// Sonstige Ausgabe
/// </summary>
public record OtherExpense : CashFlowBase {

    /// <summary>
    /// Liquiditätswirksam
    /// </summary>
    public bool IsLiquidityRelevant {
        get;
        init;
    } = true;

    /// <summary>
    /// Besteuerung
    /// </summary>
    public TaxableExpenseType TaxableExpenseType {
        get;
        init;
    } = TaxableExpenseType.None;

    /// <summary>
    /// Erzeugt eine neue Instanz der <see cref="OtherExpense"/>-Klasse
    /// </summary>
    public OtherExpense() =>
        ScenarioParameter = ScenarioParameter with { Death = 100 };

}
