namespace Gschwind.Lighthouse.Example.Models.Data;

/// <summary>
/// Wertpapierarten
/// </summary>
public enum SecurityType {

    /// <summary>
    /// Nicht bekannt
    /// </summary>
    None = -1,
    /// <summary>
    /// Anleihe
    /// </summary>
    Bond,
    /// <summary>
    /// Aktie
    /// </summary>
    Stock = 2,
    /// <summary>
    /// Aktienfonds
    /// </summary>
    StockFunds = 4,
    /// <summary>
    /// Rentenfonds
    /// </summary>
    BondFunds = 6,
    /// <summary>
    /// Immobilienfonds
    /// </summary>
    PropertyFunds = 8,
    /// <summary>
    /// Geldmarktfonds
    /// </summary>
    MoneyMarketFunds = 9,
    /// <summary>
    /// Zertifikate
    /// </summary>
    Certificate = 10,
    /// <summary>
    /// Hedgefonds
    /// </summary>
    HedgeFunds = 11,
    /// <summary>
    /// Private Equity Fonds
    /// </summary>
    PrivateEquity = 12,
    /// <summary>
    /// Dachfonds
    /// </summary>
    FundOfFunds = 13,
    /// <summary>
    /// Mischfonds
    /// </summary>
    BalancedFunds = 14,
    /// <summary>
    /// Sonstige Fonds
    /// </summary>
    OtherFunds = 15,
    /// <summary>
    /// Strukturierte Produkte
    /// </summary>
    StructuredProducts = 16,
    /// <summary>
    /// Rohstofffonds
    /// </summary>
    CommodityFunds = 17,
    /// <summary>
    /// Zerobonds
    /// </summary>
    Zerobond = 18,
}
