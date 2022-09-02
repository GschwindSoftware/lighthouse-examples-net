namespace Gschwind.Lighthouse.Example.Models.Data;

/// <summary>
/// Steuerliche Bewertungsart des Betriebsvermögens für die Erbschaftsteuer
/// </summary>
public enum CompanyValuationMethod {
    /// <summary>
    /// Vereinfachtes Ertragswertverfahren
    /// </summary>
    SimplifiedProfit = 1,
    /// <summary>
    /// Manuelle Bewertung
    /// </summary>
    Manual = 2
}
