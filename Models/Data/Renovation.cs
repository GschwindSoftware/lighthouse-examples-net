namespace Gschwind.Lighthouse.Example.Models.Data;

/// <summary>
/// Sanierung einer Immobilie
/// </summary>
public record Renovation {

    /// <summary>
    /// Abschreibungsart
    /// </summary>
    public AmortizationType AmortizationType {
        get;
        init;
    }

    /// <summary>
    /// Einheit bei manueller Eingabe der Abschreibungsart
    /// </summary>
    public UnitType ManualUnitType {
        get;
        init;
    }

    /// <summary>
    /// Bemessungsgrundlage
    /// </summary>
    public double AssessmentBasis {
        get;
        init;
    }

    /// <summary>
    /// Fertigstellungsjahr
    /// </summary>
    public DateTime CompletionDate {
        get;
        init;
    } = new(DateTime.Now.Year, 1, 1);

    /// <summary>
    /// Liquiditätswirksam
    /// </summary>
    public bool IsLiquidityRelevant {
        get;
        init;
    } = true;

    /// <summary>
    /// Wesentliche Verbesserung
    /// </summary>
    public bool SignificantImprovement {
        get;
        init;
    } = true;

    /// <summary>
    /// Aus Rücklagen
    /// </summary>
    public double FromReserves {
        get;
        init;
    }

    /// <summary>
    /// Details für manuelle Eingaben in %
    /// </summary>
    public ICollection<PercentValue> Details {
        get;
        init;
    } = new List<PercentValue>();

    /// <summary>
    /// Details für manuelle Eingaben in Währung
    /// </summary>
    public ICollection<DateValue> ManualValues {
        get;
        init;
    } = new List<DateValue>();

}
