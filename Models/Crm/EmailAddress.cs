namespace Gschwind.Lighthouse.Example.Models.Crm;

/// <summary>
/// Eine E-Mail-Adresse einer Person oder eines Unternehmens
/// </summary>
/// <param name="Id">Der eindeutige Schlüssel der E-Mail-Adresse</param>
/// <param name="Address">Die E-Mail-Adresse</param>
/// <param name="IsBusiness">Wert der angibt, ob es sich um eine geschäftliche Adresse handelt.</param>
/// <param name="IsDefault">Wert der angibt, ob es sich um die Standarsadresse handelt</param>
public record EmailAddress(
    int Id,
    string Address,
    bool IsBusiness,
    bool IsDefault
);
