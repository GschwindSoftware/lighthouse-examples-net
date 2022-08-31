using Gschwind.Lighthouse.Example.Models.Data;
using Gschwind.Lighthouse.Example.Models.Plans;
using Refit;

namespace Gschwind.Lighthouse.Example.Api;

/// <summary>
/// Definiert die Schnittstelle der Finanzplan-Endpunkte der Financial Lighthouse Rechenkern API
/// </summary>
/// <seealso href="https://api.financial-lighthouse.de/fin/swagger/index.html"/>
/// <seealso href="https://reactiveui.github.io/refit/"/>
public interface IPlanApi {

    /// <summary>
    /// Einen Plan abfragen
    /// </summary>
    /// <param name="planId">Eindeutiger Schlüssel des Plans</param>
    /// <returns>Eine Aufgabe, die die Antwort der Abfrage enthält</returns>
    [Get("/plans/{planId}")]
    Task<ApiResponse<Plan>> GetAsync(int planId);

    /// <summary>
    /// Vorgänge des Status Quo abfragen
    /// </summary>
    /// <param name="clientId">Die vom System vergebene Id des Kunden</param>
    /// <returns>Eine Aufgabe, die die Antwort der Abfrage enthält</returns>
    [Get("/plans/byClient/{clientId}/statusQuo/data")]
    Task<ApiResponse<IReadOnlyCollection<PlanData>>> GetStatusQuoDataAsync(Guid clientId);

    /// <summary>
    /// Vorgänge des Status Quo abfragen
    /// </summary>
    /// <param name="clientNumber">Die benutzerdefinierte Kundennummer des Kunden</param>
    /// <returns>Eine Aufgabe, die die Antwort der Abfrage enthält</returns>
    [Get("/plans/byClient/no:{clientNumber}/statusQuo/data")]
    Task<ApiResponse<IReadOnlyCollection<PlanData>>> GetStatusQuoDataAsync(string clientNumber);

    /// <summary>
    /// Vorgänge des Status Quo aktualisieren
    /// </summary>
    /// <param name="clientId">Die vom System vergebene Id des Kunden</param>
    /// <param name="data">Die neuen Vorgangsdaten</param>
    /// <returns>Eine Aufgabe, die die Antwort der Abfrage enthält</returns>
    [Put("/plans/byClient/{clientId}/statusQuo/data")]
    Task<IApiResponse> UpdateStatusQuoDataAsync(Guid clientId, IEnumerable<PlanData> data);

    /// <summary>
    /// Vorgänge des Status Quo aktualisieren
    /// </summary>
    /// <param name="clientNumber">Die benutzerdefinierte Kundennummer des Kunden</param>
    /// <param name="data">Die neuen Vorgangsdaten</param>
    /// <returns>Eine Aufgabe, die die Antwort der Abfrage enthält</returns>
    [Put("/plans/byClient/no:{clientNumber}/statusQuo/data")]
    Task<IApiResponse> UpdateStatusQuoDataAsync(string clientNumber, IEnumerable<PlanData> data);

}
