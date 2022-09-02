namespace Gschwind.Lighthouse.Example.Models.Data;

/// <summary>
/// Typ aus Betriebsausgaben
/// </summary>
public enum CompanyExpenseType {
    /// <summary>
    /// Personalkosten
    /// </summary>
    PersonnelCosts,
    /// <summary>
    /// Raumkosten
    /// </summary>
    RentalCosts = 1,
    /// <summary>
    /// Versicherungsbeitrag
    /// </summary>
    InsurancePremium = 2,
    /// <summary>
    /// Kraftfahrzeugkosten
    /// </summary>
    VehicleCosts = 3,
    /// <summary>
    /// Reisekosten
    /// </summary>
    TravelExpenses = 4,
    /// <summary>
    /// Gerätekosten
    /// </summary>
    EquipmentCosts = 5,
    /// <summary>
    /// Materialkosten
    /// </summary>
    MaterialCosts = 6,
    /// <summary>
    /// Bürokosten
    /// </summary>
    OfficeCosts = 7,
    /// <summary>
    /// Sonstige Kosten
    /// </summary>
    OtherCosts = 8,
    /// <summary>
    /// Werbungskosten
    /// </summary>
    AdvertisingCosts = 9
}
