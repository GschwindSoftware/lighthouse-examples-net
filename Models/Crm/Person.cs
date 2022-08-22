namespace Gschwind.Lighthouse.Example.Models.Crm;

/// <summary>
/// Ein Personenkontakt
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
/// <param name="Title">Der Titel der Person, z.B. ein akademischer Titel</param>
/// <param name="FirstName">Der Vorname der Person</param>
/// <param name="LastName">Der Nachname der Person</param>
/// <param name="Gender">Das soziale Geschlecht der Person</param>
/// <param name="Birthday">Das soziale Geschlecht der Person</param>
/// <param name="Employment">Die Beschäftigunsverhältnisse der Person</param>
/// <inheritdoc/>
public record Person(
    #region Contact

    Guid Id,
    bool IsClient,
    string? ClientNumber,
    string? Comment,
    bool IsArchived,
    byte[]? Image,
    string Type,
    ICollection<PhoneNumber> PhoneNumbers,
    ICollection<EmailAddress> EmailAddresses,
    ICollection<SocialNetworkAccount> SocialNetworkAccounts,

    #endregion

    string? Title,
    string? FirstName,
    string? LastName,
    Gender? Gender,
    DateTime? Birthday,
    Employment? Employment
) : Contact(
    Id,
    IsClient,
    ClientNumber,
    Comment,
    IsArchived,
    Image,
    Type,
    PhoneNumbers,
    EmailAddresses,
    SocialNetworkAccounts
);

