namespace Gschwind.Lighthouse.Example.Models.Crm;

/// <summary>
/// Ein Unternehmenskontakt
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
/// <param name="Name">Der vollständige Name des Unternehmens</param>
/// <param name="ShortName">Der Kurzname des Unternehmens</param>
/// <param name="Industry">Die Branche in der das Unternehmen tätig ist</param>
/// <param name="VatNumber">Die Umsatzsteuer-Identifikationsnummer des Unternehmens</param>
/// <param name="Website">Die Adresse der Webpräsenz des Unternehmens</param>
/// <param name="Employees">Die erfassten Beschäftigten des Unternehmens</param>
/// <inheritdoc/>
public record Company(
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

    string Name,
    string? ShortName,
    string? Industry,
    string? VatNumber,
    string? Website,
    ICollection<Employment> Employees
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
