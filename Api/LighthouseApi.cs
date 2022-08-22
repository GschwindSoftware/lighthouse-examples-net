namespace Gschwind.Lighthouse.Example.Api;

/// <summary>
/// Stellt Schnittstellen der Financial Lighthouse API zur Verrfügung
/// </summary>
/// <seealso href="https://api.financial-lighthouse.de/crm/swagger/index.html"/>
/// <seealso href="https://api.financial-lighthouse.de/fin/swagger/index.html"/>
public class LighthouseApi {

    /// <summary>
    /// Schnittstelle der Endpunkte der Financial Lighthouse CRM API
    /// </summary>
    public ICrmApi Crm {
        get;
    }

    /// <summary>
    /// Schnittstelle der Reporting-Endpunkte der Financial Lighthouse Rechenkern API
    /// </summary>
    public IReportingApi Reports {
        get;
    }

    /// <summary>
    /// Schnittstelle der Finanzplan-Endpunkte der Financial Lighthouse Rechenkern API
    /// </summary>
    public IPlanApi Plans {
        get;
    }

    /// <summary>
    /// Erzeugt ein neues Objekt der <see cref="LighthouseApi"/>-Klasse
    /// </summary>
    /// <param name="crmApi">Die Definition der CRM-Endpunkte</param>
    /// <param name="reportingApi">Die Definition der Reporting-Endpunkte</param>
    /// <param name="planApi">Die Definition der Finanzplan-Endpunkte</param>
    public LighthouseApi(ICrmApi crmApi, IReportingApi reportingApi, IPlanApi planApi) =>
        (Crm, Reports, Plans) = (crmApi, reportingApi, planApi);

}
