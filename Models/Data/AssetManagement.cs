namespace Gschwind.Lighthouse.Example.Models.Data;

/// <summary>
/// Vermögensverwaltung
/// </summary>
public record AssetManagement : SecurityInvestment {

    /// <summary>
    /// Depotname
    /// </summary>
    public string DepotName {
        get;
        init;
    } = String.Empty;

    /// <summary>
    /// Kontostand des Depots am Wertstellungsdatum
    /// </summary>
    public double DepotAmount {
        get;
        init;
    }

    /// <summary>
    /// Wertstellungsdatum
    /// </summary>
    public DateTime ValueDate {
        get;
        init;
    } = DateTime.Now.Date;

    /// <summary>
    /// Assetstruktur beibehalten
    /// </summary>
    public bool Rebalancing {
        get;
        init;
    }

    /// <summary>
    /// Interne Umschichtung in % pro Jahr
    /// </summary>
    public double InternalReallocation {
        get;
        init;
    }

    /// <summary>
    /// Einzahlungen
    /// </summary>
    public CashFlows Savings {
        get;
        init;
    } = new();

    /// <summary>
    /// Sondereinzahlungen
    /// </summary>
    public ICollection<DateValue> AdditionalSavings {
        get;
        init;
    } = [];

    /// <summary>
    /// Entnahmen
    /// </summary>
    public CashFlows Withdrawals {
        get;
        init;
    } = new();

    /// <summary>
    /// Sonderentnahmen
    /// </summary>
    public ICollection<DateValue> AdditionalWithdrawals {
        get;
        init;
    } = [];

    /// <summary>
    /// Gebühren aus dem Bestand bezahlen
    /// </summary>
    public bool PayFeeFromStock {
        get;
        init;
    }

    /// <summary>
    /// Anlageklassen
    /// </summary>
    public ICollection<AssetClass> AssetClasses {
        get;
        init;
    } = [];

    /// <summary>
    /// Anlagedatum
    /// </summary>
    public Buying Buying {
        get;
        init;
    } = new();

    /// <summary>
    /// Liquiditätskonto
    /// </summary>
    public AssetManagementLiquidity AssetManagementLiquidity {
        get;
        init;
    } = new();

}
