namespace Gschwind.Lighthouse.Example.Models.Data;

/// <summary>
/// Besitzer
/// </summary>
public record Owner {

    /// <summary>
    /// Typ des Besitzers
    /// </summary>
    public OwnerType Type {
        get;
        init;
    } = OwnerType.Client;

    /// <summary>
    /// Anteil des Kunden
    /// </summary>
    public double ClientRate {
        get;
        init;
    } = 50;

    /// <summary>
    /// Anteil des Parnters
    /// </summary>
    public double PartnerRate {
        get;
        init;
    } = 50;

    /// <summary>
    /// Ein <see cref="Owner"/>-Objekt mit <see cref="OwnerType.Client"/>
    /// </summary>
    public static Owner Client => new() {
        Type = OwnerType.Client
    };

    /// <summary>
    /// Ein <see cref="Owner"/>-Objekt mit <see cref="OwnerType.Partner"/>
    /// </summary>
    public static Owner Partner => new() {
        Type = OwnerType.Partner
    };

    /// <summary>
    /// Erzeugt ein <see cref="Owner"/>-Objekt mit <see cref="OwnerType.Both"/>
    /// </summary>
    /// <param name="clientRate">Anteil des Kunden</param>
    /// <param name="partnerRate">Anteil des Parnters</param>
    /// <returns>Das erzeugte <see cref="Owner"/>-Objekt</returns>
    public static Owner Both(double clientRate = 50.0, double partnerRate = 50.0) => new() {
        Type = OwnerType.Both,
        ClientRate = clientRate,
        PartnerRate = partnerRate
    };

}
