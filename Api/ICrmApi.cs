using Gschwind.Lighthouse.Example.Models;
using Gschwind.Lighthouse.Example.Models.Crm;
using Refit;

namespace Gschwind.Lighthouse.Example.Api;

/// <summary>
/// Definiert die Schnittstelle der Endpunkte der Financial Lighthouse CRM API
/// </summary>
/// <seealso href="https://api.financial-lighthouse.de/crm/swagger/index.html"/>
/// <seealso href="https://reactiveui.github.io/refit/"/>
public interface ICrmApi {

    /// <summary>
    /// Mehrere Kontakte durchsuchen
    /// </summary>
    /// <param name="q">Die Parameter der Abfrage</param>
    /// <returns>Eine Aufgabe, die die Antwort der Abfrage enthält</returns>
    [Post("/contacts/query")]
    Task<ApiResponse<QueryResult<Contact>>> QueryContactsAsync(Query q);

}
