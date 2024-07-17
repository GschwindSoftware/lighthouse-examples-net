namespace Gschwind.Lighthouse.Example.Models.Data;

/// <summary>
/// Riesterrente
/// </summary>
public record RiesterPension : PrivatePension {

    /// <summary>
    /// Bereits erhaltene Zulagen
    /// </summary>
    public ICollection<DateValue> AlreadyReceivedBonus {
        get;
        init;
    } = [];

}
