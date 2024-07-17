namespace Gschwind.Lighthouse.Example.Models.Data;

/// <summary>
/// Klasse zur Erfassung von Zahlungsströmen
/// </summary>
public record CashFlows {

    /// <summary>
    /// Zahlungsintervall
    /// </summary>
    public Period Period {
        get;
        init;
    }

    /// <summary>
    /// Liste von Zahlungsflüssen
    /// </summary>
    public ICollection<CashFlow> Values {
        get;
        init;
    } = [];

    /// <summary>
    /// Liste von Steigerungen
    /// </summary>
    public ICollection<PercentValue> Increases {
        get;
        init;
    } = [];

}
