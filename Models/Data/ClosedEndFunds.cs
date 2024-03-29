namespace Gschwind.Lighthouse.Example.Models.Data;

/// <summary>
/// Geschlossener Fond
/// </summary>
public record ClosedEndFunds : SelfContainedPlanData {

    /// <summary>
    /// Beteiligungssumme
    /// </summary>
    public double Investment {
        get;
        init;
    }

    /// <summary>
    /// Stammdaten des geschlossenen Fonds
    /// </summary>
    public FundsMasterData MasterData {
        get;
        init;
    } = new();

    /// <summary>
    /// Besteuerung des Verkaufserlöses
    /// </summary>
    public Taxation SaleTaxation {
        get;
        init;
    } = Taxation.IncomeTax;

    /// <summary>
    /// Steuersatz für die automatische Berechnung der Verkehrswerte in %
    /// </summary>
    public double TaxRate {
        get;
        init;
    } = 50;

    /// <summary>
    /// Abzinsfaktor für die automatische Berechnung der Verkehrswerte in %
    /// </summary>
    public double DiscountFactor {
        get;
        init;
    } = 5;

    /// <summary>
    /// Bareinlage in % (nachrichtlich)
    /// </summary>
    public double CashContribution {
        get;
        init;
    } = 100;

}
