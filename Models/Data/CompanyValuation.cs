namespace Gschwind.Lighthouse.Example.Models.Data;

/// <summary>
/// Steuerliche Bewertung von Betriebsvermögen in der Erbschaftsteuer
/// </summary>
public record CompanyValuation {

    /// <summary>
    /// Bewertungsmethode
    /// </summary>
    public CompanyValuationMethod ValuationMethod {
        get;
        init;
    } = CompanyValuationMethod.Manual;

    /// <summary>
    /// Grundstücksart
    /// </summary>
    public CompanyBenefitType BenefitType {
        get;
        init;
    } = CompanyBenefitType.None;

    /// <summary>
    /// Vereinfachtes Ertragswertverfahren
    /// </summary>
    public SimplifiedProfitValuation SimplifiedProfitValuation {
        get;
        init;
    } = new();

    /// <summary>
    /// Manuelle Bewertung
    /// </summary>
    public CompareValuation CompareValuation {
        get;
        init;
    } = new();

    /// <summary>
    /// Netto-Verwaltungsvermögen
    /// </summary>
    public double AdministrativeAssets {
        get;
        init;
    }

}
