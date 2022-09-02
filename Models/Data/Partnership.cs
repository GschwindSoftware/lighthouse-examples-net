namespace Gschwind.Lighthouse.Example.Models.Data;

/// <summary>
/// Personengesellschaft
/// </summary>
public record Partnership : PrivateCompany {

    /// <summary>
    /// Gesellschaftsform
    /// </summary>
    public CompanyType CompanyType {
        get;
        init;
    } = CompanyType.GbR;

}
