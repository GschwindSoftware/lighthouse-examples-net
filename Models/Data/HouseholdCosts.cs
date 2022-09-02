namespace Gschwind.Lighthouse.Example.Models.Data;

/// <summary>
/// Ausgabe für Lebensführung
/// </summary>
public record HouseholdCosts : PlanData {

    /// <summary>
    /// Konsumgruppen
    /// </summary>
    public ICollection<LivingCostsCategory> Categories {
        get;
        init;
    } = new List<LivingCostsCategory>();

    /// <summary>
    /// Kinder mit in die Haushaltskostenberechnung einbeziehen
    /// </summary>
    public bool IncludeChildren {
        get;
        init;
    } = true;

    /// <summary>
    /// Manueller Wert soll benutzt werden
    /// </summary>
    public bool ManualInput {
        get;
        init;
    }

    /// <summary>
    /// Manueller Wert
    /// </summary>
    public double ManualValue {
        get;
        init;
    }

    /// <summary>
    /// Ende der Zahlungen
    /// </summary>
    public Moment Termination {
        get;
        init;
    } = new();

}
