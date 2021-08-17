using System;
using System.Text.Json.Serialization;
using Gschwind.Lighthouse.Example.Authentication;

namespace Gschwind.Lighthouse.Example.Models.Authentication {

    /// <summary>
    /// Die Antwort einer Authentifizierung mit OAuth
    /// </summary>
    /// <seealso cref="ClientCredentialsHandler"/>
    /// <seealso href="https://www.oauth.com/oauth2-servers/access-tokens/access-token-response/"/>
    public record TokenResponse {

        /// <summary>
        /// Das enthaltene Access Token zur Autorisierung von Abfragen
        /// </summary>
        [JsonPropertyName("access_token")]
        public string AccessToken {
            get;
            init;
        } = String.Empty;

        /// <summary>
        /// Die Zeitspanne bis zum Ablauf des Tokens, in Sekunden
        /// </summary>
        [JsonPropertyName("expires_in")]
        public int ExpiresIn {
            get;
            init;
        }

        /// <summary>
        /// Der Typ des Tokens
        /// </summary>
        [JsonPropertyName("token_type")]
        public string TokenType {
            get;
            init;
        } = String.Empty;

        /// <summary>
        /// Der Scope, der mit dem Token gewährt wurde
        /// </summary>
        public string Scope {
            get;
            init;
        } = String.Empty;

    }

}
