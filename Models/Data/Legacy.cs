namespace Gschwind.Lighthouse.Example.Models.Data;

/// <summary>
/// Vermächtnis
/// </summary>
public record Legacy {

    /// <summary>
    /// Vermächtnisnehmer
    /// </summary>
    public Guid PersonId {
        get;
        init;
    } = new("11111111-1111-1111-1111-111111111111");

    /// <summary>
    /// Name des Vermächtnisnehmers
    /// </summary>
    public string PersonName {
        get;
        init;
    } = "";

    /// <summary>
    /// Vermächtnistyp
    /// </summary>
    public LegacyType Type {
        get;
        init;
    } = LegacyType.Cash;

    /// <summary>
    /// Vorgang bei Stückvermächtnis
    /// </summary>
    public Guid? FinanceId {
        get;
        init;
    } = Guid.Empty;

    /// <summary>
    /// Vorgang bei Nießbrauchvermächtnis
    /// </summary>
    public Guid? UsufructId {
        get;
        init;
    } = Guid.Empty;

    /// <summary>
    /// Manuelle Erbquote
    /// </summary>
    public double Quote {
        get;
        init;
    }

    /// <summary>
    /// Wert beim Geldvermächtnis
    /// </summary>
    public double Value {
        get;
        init;
    }

    /// <summary>
    /// Kürzung nach §2324 BGB zulässig
    /// </summary>
    public bool HasReduction {
        get;
        init;
    } = true;

}
