namespace Gschwind.Lighthouse.Example.Models.Data;

/// <summary>
/// Einmalige Einkunft
/// </summary>
public record SingleIncome : SingleCashFlow {

    /// <summary>
    /// Einkunftsart
    /// </summary>
    public IncomeType IncomeType {
        get;
        init;
    } = IncomeType.Other;

    /// <summary>
    /// Zu versteuern
    /// </summary>
    public double Taxable {
        get;
        init;
    }

    /// <summary>
    /// Art der Besteuerung
    /// </summary>
    public Taxation Taxation {
        get;
        init;
    } = Taxation.IncomeTax;

}
