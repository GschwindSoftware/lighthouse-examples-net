namespace Gschwind.Lighthouse.Example.Models.Crm;

/// <summary>
/// Die Adresse eines Kontakts
/// </summary>
/// <param name="Id">Der eindeutige Schlüssel der Adresse</param>
/// <param name="Street">Die Straße der Adresse</param>
/// <param name="PostalCode">Die Postleitzahl der Adresse</param>
/// <param name="City">Die Stadt der Adresse</param>
/// <param name="State">Der Staat (Bundesland, Kanton) der Adresse</param>
/// <param name="Country">Das Land der Adresse</param>
/// <param name="IsBusiness">Gibt an, ob es sich um eine berufliche Adresse handelt</param>
/// <param name="IsDefault">Gibt an, ob die Adresse die Hauptadresse des Kontakts ist</param>
public record Address(
    int Id,
    string? Street,
    string? PostalCode,
    string? City,
    string? State,
    Country? Country,
    bool IsBusiness,
    bool IsDefault
);
