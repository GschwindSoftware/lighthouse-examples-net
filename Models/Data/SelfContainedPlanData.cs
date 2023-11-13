namespace Gschwind.Lighthouse.Example.Models.Data;

/// <summary>
/// Basis für alle Vorgänge, die für sich alleine existieren können.
/// </summary>
/// <remarks>
/// Vorgänge, die ein <see cref="PlanData"/>, aber kein <see cref="SelfContainedPlanData"/> sind
/// werden nur als Unterobjekte in einem anderen <see cref="SelfContainedPlanData"/> genutzt und können nicht
/// in die Vorgangsliste eines Plans eingetragen werden.
/// </remarks>
public abstract record SelfContainedPlanData : PlanData {

    /// <summary>
    /// Ein eindeutiger Schlüssel, der einen externen Datensatz in Bezug bringt, falls der Vorgang importiert wurde
    /// </summary>
    /// <seealso cref="ImportProvider"/>
    public string ImportId {
        get;
        init;
    } = String.Empty;

    /// <summary>
    /// Der Name des Synchronisations-Anbieters, der den Vorgang aus externen Daten importiert hat
    /// </summary>
    /// <seealso cref="ImportId"/>
    public string? ImportProvider {
        get;
        init;
    }

    /// <summary>
    /// Nachrichtliche Informationen
    /// </summary>
    public Informations Informations {
        get;
        init;
    } = new();

    /// <summary>
    /// Besitzer
    /// </summary>
    public Owner Owner {
        get;
        init;
    } = new();

}
