using Microsoft.Extensions.Logging;
using Newtonsoft.Json;

namespace Gschwind.Lighthouse.Example;

record ExternalSecurity(string Isin, double Quantity);
record ExternalSecuritiesAccount(string Iban, IEnumerable<ExternalSecurity> Securities);
record ExternalClientPortfolio(string clientId, IEnumerable<ExternalSecuritiesAccount> Accounts);

/// <summary>
/// Deutet eine externe Quelle für Kundendaten an
/// </summary>
internal class ExternalClientDataProvider {

    #region Abhängigkeiten

    readonly JsonSerializerSettings _jsonSettings;
    readonly ILogger<ExternalClientDataProvider> _logger;

    public ExternalClientDataProvider(JsonSerializerSettings jsonSettings, ILogger<ExternalClientDataProvider> logger) =>
        (_jsonSettings, _logger) = (jsonSettings, logger);

    #endregion

    /// <summary>
    /// Wertpapierdepots auslesen
    /// </summary>
    /// <returns>
    /// Eine <see cref="Task{TResult}"/>, die die Wertpapierdeopts enthält.
    /// </returns>
    internal async Task<IEnumerable<ExternalClientPortfolio>?> GetProtfoliosAsync() {
        try {
            var json = await File.ReadAllTextAsync("portfolios.json");
            return JsonConvert.DeserializeObject<IEnumerable<ExternalClientPortfolio>>(json, _jsonSettings);
        } catch (Exception e) {
            _logger.LogError(e, "Plan konnte nicht geladen werden.");
        }

        return null;
    }

}
