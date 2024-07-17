namespace Gschwind.Lighthouse.Example.Models.Data;

/// <summary>
/// Stiftung
/// </summary>
public record Foundation : SelfContainedPlanData {

    /// <summary>
    /// Anteil
    /// </summary>
    public FoundationType FoundationType {
        get;
        init;
    } = FoundationType.Charitable;

    /// <summary>
    /// Gründungsdatum
    /// </summary>
    public DateTime FoundingDate {
        get;
        init;
    } = new DateTime(DateTime.Now.Year + 1, 1, 1);

    /// <summary>
    /// Liste der Destinäre (Personen, die von der Stiftung satzungsgemäß profitieren)
    /// </summary>
    public ICollection<Beneficiary> Destinaries {
        get;
        init;
    } = new List<Beneficiary>();

    /// <summary>
    /// Stiftungsvermögen
    /// </summary>
    public ICollection<PlanData> Assets {
        get;
        init;
    } = new List<PlanData>();

}
