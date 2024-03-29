namespace Gschwind.Lighthouse.Example.Models.Data;

/// <summary>
/// Festgeld
/// </summary>
public record TimeMoney : TimeDeposit {

    /// <summary>
    /// Erzeugt eine neue Instanz der <see cref="TimeMoney"/>-Klasse
    /// </summary>
    public TimeMoney() =>
        (IsCumulative, InterestPeriod) = (false, Period.Yearly);

}
