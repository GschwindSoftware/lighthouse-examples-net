namespace Gschwind.Lighthouse.Example.Models.Data;

/// <summary>
/// Begünstiger
/// </summary>
public record Beneficiary {

    /// <summary>
    /// Begünstigter / Erbe
    /// </summary>
    public Guid PersonId {
        get;
        init;
    } = Guid.Empty;

    /// <summary>
    /// Name des Begünstigten
    /// </summary>
    public string PersonName {
        get;
        init;
    } = "Begünstigter";

    /// <summary>
    /// Typ des Begünstigten / Erben
    /// </summary>
    public RelativeType Type {
        get;
        init;
    } = RelativeType.Spouse;

    /// <summary>
    /// Liste der Vermächtnisse
    /// </summary>
    public ICollection<Legacy> Legacies {
        get;
        init;
    } = [];

}
