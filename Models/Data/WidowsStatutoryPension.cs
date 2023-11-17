namespace Gschwind.Lighthouse.Example.Models.Data;

/// <summary>
/// Gesetzliche Witwenrente
/// </summary>
public record WidowsStatutoryPension : SelfContainedPlanData {

    /// <summary>
    /// Start der Rentenzahlung
    /// </summary>
    public DateTime StartDate {
        get;
        init;
    } = new(DateTime.Now.Year, 1, 1);

    /// <summary>
    /// Enddatum der Rentenzahlung
    /// </summary>
    public DateTime EndDate {
        get;
        init;
    } = new(DateTime.Now.Year + 10, 1, 1);

    /// <summary>
    /// Endeart der Rentenzahlung
    /// </summary>
    public PensionEnd PensionEnd {
        get;
        init;
    } = PensionEnd.Death;

    /// <summary>
    /// Monatliche Rente
    /// </summary>
    public double MonthlyPension {
        get;
        init;
    }

}
