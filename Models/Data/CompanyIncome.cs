namespace Gschwind.Lighthouse.Example.Models.Data;

/// <summary>
/// Betriebseinnahme
/// </summary>
public record CompanyIncome : CashflowSubFinance {

    /// <summary>
    /// Typ der Einnahmen
    /// </summary>
    public CompanyIncomeType CompanyIncomeType {
        get;
        init;
    }

}
