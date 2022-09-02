namespace Gschwind.Lighthouse.Example.Models.Family;

/// <summary>
/// Stellt den Versicherungsstatus eines Kontaktes dar
/// </summary>
public record StateInsurances {

    /// <summary>
    /// Kennung, ob Krankenversicherung bei Kontakt vorhanden
    /// </summary>
    public bool Health {
        get;
        init;
    } = true;

    /// <summary>
    /// Kennung, ob Rentenversicherung bei Kontakt vorhanden
    /// </summary>
    public bool Pension {
        get;
        init;
    } = true;

    /// <summary>
    /// Kennung, ob Arbeitslosenversicherung bei Kontakt vorhanden
    /// </summary>
    public bool Unemployment {
        get;
        init;
    } = true;

}
