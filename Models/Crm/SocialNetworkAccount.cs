namespace Gschwind.Lighthouse.Example.Models.Crm;

/// <summary>
/// Ein Social-Media-Konto einer Person oder eines Unternehmens
/// </summary>
/// <param name="Id">Der eindeutige Schlüssel des Kontos</param>
/// <param name="Username">Der Nutzername, bzw. das Handle des Kontos</param>
/// <param name="Service">Das soziale Netzwerk, auf dem das Konto existiert</param>
public record SocialNetworkAccount(
    int Id,
    string Username,
    SocialNetworkService Service
);
