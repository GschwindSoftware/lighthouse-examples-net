namespace Gschwind.Lighthouse.Example.Models.Data;

/// <summary>
/// Vermögensverwaltende Gesellschaft
/// </summary>
public record AssetManagementCompany : CompanyBase {

    /// <summary>
    /// Gesellschaftsform
    /// </summary>
    public CompanyForm CompanyForm {
        get;
        set;
    } = CompanyForm.Partnership;

    /// <summary>
    /// Werden alle Gewinne ausgeschüttet?
    /// </summary>
    public bool DistributeAllProfit {
        get;
        set;
    } = true;

    /// <summary>
    /// Gewinnausschüttung, falls nicht alle Gewinne ausgeschüttet werden
    /// </summary>
    public CashFlows ProfitDistribution {
        get;
        set;
    } = new() { Period = Period.Yearly };

    /// <summary>
    /// Girokonten
    /// </summary>
    public ICollection<CheckingAccount> CheckingAccounts {
        get;
        set;
    } = [];

    /// <summary>
    /// Depots
    /// </summary>
    public ICollection<SecuritiesAccount> Deposits {
        get;
        set;
    } = [];

    /// <summary>
    /// Fremdgenutzte Immobilien
    /// </summary>
    public ICollection<RentalProperty> RentalProperties {
        get;
        set;
    } = [];

    /// <summary>
    /// Sonstiges Vermögen
    /// </summary>
    public ICollection<OtherAsset> OtherAssets {
        get;
        set;
    } = [];

    /// <summary>
    /// Darlehen
    /// </summary>
    public ICollection<Loan> Loans {
        get;
        set;
    } = [];

}
