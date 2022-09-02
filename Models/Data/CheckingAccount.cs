namespace Gschwind.Lighthouse.Example.Models.Data;

/// <summary>
/// Girokonto
/// </summary>
public record CheckingAccount : DemandDeposit {

    /// <summary>
    /// Erzeugt eine neue Instanz der <see cref="CheckingAccount"/>-Klasse
    /// </summary>
    public CheckingAccount() =>
        InterestPeriod = Period.Quarterly;

}
