namespace Gschwind.Lighthouse.Example.Models.Data;

/// <summary>
/// Bewertungsart der Immobilien
/// </summary>
public enum PropertyValuationType {
    /// <summary>
    /// (§179 BewG) Unbebautes Grundstück
    /// </summary>
    Undeveloped,
    /// <summary>
    /// (§182 BewG) Bebautes Grundstück
    /// </summary>
    Developed = 1,
    /// <summary>
    /// (§193 BewG) Erbbaurecht
    /// </summary>
    BuildingLeasehold = 5,
    /// <summary>
    /// (§194 BewG) Erbbaugrundstück
    /// </summary>
    GroundLeashold = 6,
    /// <summary>
    /// Auslandsimmobilie
    /// </summary>
    Foreign = 100
}
