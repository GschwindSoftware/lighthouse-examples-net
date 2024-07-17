namespace Gschwind.Lighthouse.Example.Models.Data;

/// <summary>
/// Stück-Schenkung
/// </summary>
public record AssetGift : SingleCashFlow {

    /// <summary>
    /// Anteil
    /// </summary>
    public double Quote {
        get;
        init;
    } = 100.0;

    /// <summary>
    /// Beschenkter
    /// </summary>
    public Guid Donee {
        get;
        init;
    } = Guid.Empty;

    /// <summary>
    /// Geschenk
    /// </summary>
    public Guid GiftId {
        get;
        init;
    } = Guid.Empty;

    /// <summary>
    /// Nießbrauchvorbehalt
    /// </summary>
    public bool Usufruct {
        get;
        init;
    }

    /// <summary>
    /// Steuerwert
    /// </summary>
    public double TaxValue {
        get;
        init;
    }

    /// <summary>
    /// Bezahlte Schenkungssteuer
    /// </summary>
    public double PaidGiftTax {
        get;
        init;
    }

    /// <summary>
    /// Indexierung des Wertes
    /// </summary>
    public bool Indexation {
        get;
        init;
    } = true;


    /// <summary>
    /// Anrechnung auf den Pflichtteil
    /// </summary>
    public bool ChargeLegalPortion {
        get;
        init;
    }

    /// <summary>
    /// Steuern automatisch berechnen
    /// </summary>
    public bool AutomaticTax {
        get;
        init;
    }

}
