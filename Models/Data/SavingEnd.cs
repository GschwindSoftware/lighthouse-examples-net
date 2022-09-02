namespace Gschwind.Lighthouse.Example.Models.Data;

/// <summary>
/// Ende des Sparvorgangs
/// </summary>
public record SavingEnd {

    /// <summary>
    /// Art des Zeitpunktes
    /// </summary>
    public SavingEndType Type {
        get;
        init;
    } = SavingEndType.AtMinimumBalance;

    /// <summary>
    /// Datum des Zeitpunktes (bei <see cref="MomentType.AtDate"/>)
    /// </summary>
    public DateTime Date {
        get;
        init;
    } = new(DateTime.Now.Year + 10, 1, 1);

}
