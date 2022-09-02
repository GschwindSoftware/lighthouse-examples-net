namespace Gschwind.Lighthouse.Example.Models.Plans.Settings;

/// <summary>
/// Der Erbe / die Erbin
/// </summary>
public record Heritage : Beneficiary {

    /// <summary>
    /// Erbquote
    /// </summary>
    public double Quote {
        get;
        init;
    }

    /// <summary>
    /// Liefert die Quote als Enum
    /// </summary>
    public HeritageQuote HeritageQuote {
        get;
        init;
    }

}
