using System.Net.Http;

namespace Refit {

    /// <summary>
    /// Stellt Erweiterungsmethoden für <see cref="ApiResponse{T}"/> zur Verfügung
    /// </summary>
    internal static class ApiResponseExtensions {

        /// <summary>
        /// Löst eine <see cref="HttpRequestException"/> aus, falls die Abfrage keinen Statuscode 2xx zurückgibt
        /// </summary>
        /// <typeparam name="T">Der Typ des Payloads</typeparam>
        /// <param name="response">Die untersucht <see cref="ApiResponse{T}"/></param>
        /// <returns>Der in der Antwort enthaltene Payload</returns>
        internal static T EnsureSuccess<T>(this ApiResponse<T> response) where T : class {
            if (!response.IsSuccessStatusCode || response is not { Content: { } content })
                throw new HttpRequestException($"Fehlerhafter API-Aufruf", response.Error,  response.StatusCode);

            return content;
        }

    }

}
