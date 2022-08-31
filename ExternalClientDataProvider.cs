using Microsoft.Extensions.Logging;
using Newtonsoft.Json;

namespace Gschwind.Lighthouse.Example;

/// <summary>
/// Ein Wertpapier aus externer Quelle
/// </summary>
/// <param name="Isin">Die ISIN</param>
/// <param name="Quantity">Die Stückzahl</param>
/// <param name="Quote">Der aktuelle Kurs</param>
/// <seealso cref="ExternalSecuritiesAccount"/>
record ExternalSecurity(string Isin, double Quantity, double Quote);

/// <summary>
/// Ein Wertpapierdepot aus externer Quelle
/// </summary>
/// <param name="Iban">Die IBAN</param>
/// <param name="Securities">Der Inhalt des Depots</param>
/// <seealso cref="ExternalClientPortfolio"/>
record ExternalSecuritiesAccount(string Iban, IEnumerable<ExternalSecurity> Securities);

/// <summary>
/// Ein Kundenportfolio aus externer Quelle
/// </summary>
/// <param name="ClientId">Die Kundennummer</param>
/// <param name="Accounts">Die Wertpapierdepots des Kunden</param>
record ExternalClientPortfolio(string ClientId, IEnumerable<ExternalSecuritiesAccount> Accounts);

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
    internal async Task<IEnumerable<ExternalClientPortfolio>?> GetPortfoliosAsync() {
        try {
            var json = await File.ReadAllTextAsync("portfolios.json");
            return JsonConvert.DeserializeObject<IEnumerable<ExternalClientPortfolio>>(json, _jsonSettings);
        } catch (Exception e) {
            _logger.LogError(e, "Plan konnte nicht geladen werden.");
        }

        return null;
    }

}
