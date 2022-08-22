namespace Gschwind.Lighthouse.Example.Api;

/// <summary>
/// Stellt Schnittstellen der Financial Lighthouse API zur Verrfügung
/// </summary>
/// <seealso href="https://api.financial-lighthouse.de/fin/swagger/index.html"/>
public class LighthouseApi {

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
    /// <param name="reportingApi">Die Definition der Reporting-Endpunkte</param>
    /// <param name="planApi">Die Definition der Finanzplan-Endpunkte</param>
    public LighthouseApi(IReportingApi reportingApi, IPlanApi planApi) =>
        (Reports, Plans) = (reportingApi, planApi);

}
