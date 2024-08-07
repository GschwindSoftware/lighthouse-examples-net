namespace Gschwind.Lighthouse.Example.Models.Data;

/// <summary>
/// Sortierte Liste von Werten zu einem Datum mit einer definierten Periode
/// </summary>
public record PeriodValues {

    /// <summary>
    /// Liste von Zahlungsflüssen
    /// </summary>
    public ICollection<DateValue> Values {
        get;
        init;
    } = [];

    /// <summary>
    /// Zahlungsintervall
    /// </summary>
    public Period Period {
        get;
        init;
    } = Period.Yearly;

}
