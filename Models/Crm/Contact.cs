namespace Gschwind.Lighthouse.Example.Models.Crm;

/// <summary>
/// Ein Kontakt
/// </summary>
/// <param name="Id">Der eindeutige Schlüssel des Kontakts</param>
/// <param name="IsClient">Ist der Kontakt ein Kunde?</param>
/// <param name="ClientNumber">Die Kundennummer des Kontakts</param>
/// <param name="Comment">Ein frei wählbarer Kommentar zum Kontakt</param>
/// <param name="IsArchived">Ist der Kontakt archiviert</param>
/// <param name="Image">Ein Bild des Kontakts</param>
/// <param name="Type">Der Typ des Kontakts zur Darstellung</param>
/// <param name="PhoneNumbers">Die Telefon- und Faxnummern des Kontakts</param>
/// <param name="EmailAddresses">Die E-Mail-Adressen des Kontakts</param>
/// <param name="SocialNetworkAccounts">Die Social-Media-Konten des Kontakts</param>
public abstract record Contact(
    Guid Id,
    bool IsClient,
    string? ClientNumber,
    string? Comment,
    bool IsArchived,
    byte[]? Image,
    string Type,
    ICollection<PhoneNumber> PhoneNumbers,
    ICollection<EmailAddress> EmailAddresses,
    ICollection<SocialNetworkAccount> SocialNetworkAccounts
);
