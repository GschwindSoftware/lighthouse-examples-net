namespace Gschwind.Lighthouse.Example.Models.Crm;

/// <summary>
/// Eine Rufnummer einer Person oder eines Unternehmens
/// </summary>
/// <param name="Id">Der eindeutige Schlüssel der Rufnummer</param>
/// <param name="Number">Die Bestandteile der Rufnummer</param>
/// <param name="FullNumber">Die formatierte Telefonnummer</param>
/// <param name="Type">Der Typ der Rufnummer</param>
/// <param name="IsBusiness">Gibt an, ob die Rufnummer beruflich ist.</param>
/// <param name="IsDefault">Gibt an, ob die Rufnummer die Hauptnummer des Kontakts ist</param>
public record PhoneNumber(
    int Id,
    PhoneNumberParts Number,
    string FullNumber,
    PhoneNumberType Type,
    bool IsBusiness,
    bool IsDefault
);
