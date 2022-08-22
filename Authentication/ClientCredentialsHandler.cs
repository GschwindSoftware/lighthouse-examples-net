using System.ComponentModel.DataAnnotations;
using System.IdentityModel.Tokens.Jwt;
using System.Net.Http.Json;
using System.Text;
using Gschwind.Lighthouse.Example.Models.Authentication;
using Microsoft.Extensions.Options;

namespace Gschwind.Lighthouse.Example.Authentication {

    /// <summary>
    /// Ein <see cref="DelegatingHandler"/>, der eine OAuth Authentifizierung nach dem Client Credentials Flow vornimmt und das
    /// Access Token zur Autorisierung mit jedem Aufruf übergibt
    /// </summary>
    /// <seealso href="https://datatracker.ietf.org/doc/html/rfc6749#section-4.4"/>
    /// <seealso cref="OAuthOptions"/>
    public class ClientCredentialsHandler : DelegatingHandler {

        readonly IHttpClientFactory _clientFactory;
        readonly OAuthOptions _options;

        JwtSecurityToken? _accessToken;

        /// <summary>
        /// Erzeugt ein neues Objekt der <see cref="ClientCredentialsHandler"/>-Klasse
        /// </summary>
        /// <param name="clientFactory">Die <see cref="IHttpClientFactory"/> zur Erzeugung von <see cref="HttpClient"/>-Instanzen.</param>
        /// <param name="options">Die Optionen der OAuth-Authentifizierung.</param>
        public ClientCredentialsHandler(IHttpClientFactory clientFactory, IOptions<OAuthOptions> options) {
            options.Value.ThrowIfInvalid();
            _clientFactory = clientFactory;
            _options = options.Value;
        }

        /// <inheritdoc/>
        protected override async Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken) {
            var token = await GetAccessTokenAsync();
            request.Headers.Add("Authorization", $"Bearer {token.RawData}");
            return await base.SendAsync(request, cancellationToken);
        }

        // Bestehendes Access Token zurückgeben oder neues Access Token abrufen
        async Task<JwtSecurityToken> GetAccessTokenAsync() {
            if (_accessToken is not { ValidTo: var dt } || DateTime.Now.AddMinutes(5) > dt) {
                using var client = _clientFactory.CreateClient("oauth");

                var message = new HttpRequestMessage(HttpMethod.Post, "connect/token") {
                    Content = new FormUrlEncodedContent(new Dictionary<string, string> {
                        ["grant_type"] = "client_credentials",
                        ["scope"] = _options.Scope
                    }!)
                };

                message.Headers.Authorization = new("Basic", Base64($"{_options.ClientId}:{_options.ClientSecret}"));

                var resp = await client.SendAsync(message);
                if (!resp.IsSuccessStatusCode)
                    throw new UnauthorizedAccessException();

                var tokenResponse = await resp.Content.ReadFromJsonAsync<TokenResponse>()
                    ?? throw new FormatException();

                _accessToken = new JwtSecurityToken(tokenResponse.AccessToken);
            }

            return _accessToken;
        }

        // String → Base64
        static string Base64(string s) =>
            Convert.ToBase64String(Encoding.UTF8.GetBytes(s));

    }

}
