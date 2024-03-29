namespace Gschwind.Lighthouse.Example.Models.Data;

/// <summary>
/// Lebenshaltungskosten
/// </summary>
public record LivingCosts : CashFlowBase {

    /// <summary>
    /// Erzeugt eine neue Instanz der <see cref="LivingCosts"/>-Klasse
    /// </summary>
    public LivingCosts() =>
        ScenarioParameter = ScenarioParameter with { Death = 100 };

}
