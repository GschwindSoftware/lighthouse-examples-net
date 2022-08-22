using Gschwind.Lighthouse.Example.Models.Plans;
using Refit;

namespace Gschwind.Lighthouse.Example.Api {

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

    }

}
