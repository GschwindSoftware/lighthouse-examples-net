namespace Gschwind.Lighthouse.Example.Models.Data;

/// <summary>
/// Untervorgang Betriebsausgabe
/// </summary>
public record CompanyExpense : CashflowSubFinance {

    /// <summary>
    /// Kostenart
    /// </summary>
    public CompanyExpenseType CompanyExpenseType {
        get;
        init;
    }

}
