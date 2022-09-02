namespace Gschwind.Lighthouse.Example.Models.Data;

/// <summary>
/// Art des Bonus, der gezahlt wird
/// </summary>
public enum BonusType {
    /// <summary>
    /// Kein Bonus
    /// </summary>
    NoBonus,
    /// <summary>
    /// Sonderzinsen
    /// </summary>
    AdditionalInterests = 1,
    /// <summary>
    /// Bonus zum Laufzeitende
    /// </summary>
    AtPayout = 2
}
