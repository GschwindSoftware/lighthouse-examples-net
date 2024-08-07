namespace Gschwind.Lighthouse.Example.Models.Data;

/// <summary>
/// Investition bei Betriebsvermögen
/// </summary>
public record CompanyInvestment : PlanData {

    /// <summary>
    /// Investition
    /// </summary>
    public DateValue Investment {
        get;
        init;
    } = new();

    /// <summary>
    /// Abschreibungstyp
    /// </summary>
    public CompanyAmortizationType CompanyAmortizationType {
        get;
        init;
    } = CompanyAmortizationType.Linear;

    /// <summary>
    /// Dauer der Abschreibung in Jahren
    /// </summary>
    public int AmortizationDuration {
        get;
        init;
    } = 3;

    /// <summary>
    /// Wert für die Degressive Abschreibung in %
    /// </summary>
    public double DegressiveRate {
        get;
        init;
    } = 20;

    /// <summary>
    /// Liquiditätsabfluss?
    /// </summary>
    public bool LiquidityOutflow {
        get;
        init;
    } = true;

    /// <summary>
    /// Manuelle Abschreibung
    /// </summary>
    public ICollection<DateValue> ManualAmortization {
        get;
        init;
    } = [];

}
