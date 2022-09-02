namespace Gschwind.Lighthouse.Example.Models.Data;

/// <summary>
/// Gesetzliche Rentenversicherung
/// </summary>
public record StatutoryPension : StatePension {

    /// <summary>
    /// Erwerbsunfähigkeitsrente
    /// </summary>
    public double DisabilityPension {
        get;
        init;
    }

    /// <summary>
    /// Wird die Altersrente bei Erwerbsunfähigkeit reduziert?
    /// </summary>
    public bool HasReducedPension {
        get;
        init;
    }

    /// <summary>
    /// Reduzierte Altersrente bei Erwerbsunfähigkeit
    /// </summary>
    public double ReducedPension {
        get;
        init;
    }

    /// <summary>
    /// Witwenrente ist befristet
    /// </summary>
    public bool WidowsPensionLimitation {
        get;
        init;
    }

    /// <summary>
    /// Laufzeit der Witwenrente in Monate
    /// </summary>
    public int WidowsPensionDuration {
        get;
        init;
    } = 24;

}
