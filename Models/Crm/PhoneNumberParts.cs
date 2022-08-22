namespace Gschwind.Lighthouse.Example.Models.Crm;

/// <summary>
/// Eine Rufnummer einer Person oder eines Unternehmens
/// </summary>
/// <param name="CountryCode">Die Landesvorwahl</param>
/// <param name="AreaCode">Die Orts- oder Mobilfunkvorwahl</param>
/// <param name="SubscriberNumber">Die Teilnehmernummer</param>
/// <param name="Extension">Die Durchwahl</param>
public record PhoneNumberParts(
    string? CountryCode,
    string? AreaCode,
    string SubscriberNumber,
    string? Extension
);
