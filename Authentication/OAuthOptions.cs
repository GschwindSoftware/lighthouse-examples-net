using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;

namespace Gschwind.Lighthouse.Example.Authentication {

    /// <summary>
    /// Die OAuth-Optionen zur Autorisierung an Financial Lighthouse Endpunkte
    /// </summary>
    /// <remarks>
    /// Die Optionen gehen von einem Client Credential Flow aus
    /// </remarks>
    /// <seealso href="https://datatracker.ietf.org/doc/html/rfc6749#section-4.4"/>
    /// <seealso href="https://www.financial-lighthouse.de/admin/Integration/Index"/>
    /// <seealso cref="ClientCredentialsHandler"/>
    public class OAuthOptions : IValidatableObject {

        /// <summary>
        /// Die Id des OAuth Clients
        /// </summary>
        /// <seealso href="https://datatracker.ietf.org/doc/html/rfc6749#section-2.2"/>
        public string ClientId {
            get;
            set;
        } = string.Empty;

        /// <summary>
        /// Das Secret des OAuth Clients
        /// </summary>
        /// <seealso href="https://datatracker.ietf.org/doc/html/rfc6749#section-2.3.1"/>
        [DebuggerHidden]
        public string ClientSecret {
            get;
            set;
        } = string.Empty;

        /// <summary>
        /// Der Scope, der dem Client verfügbar sein soll
        /// </summary>
        /// <remarks>
        /// Der Client muss die entsprechenden Berechtigungen besitzen
        /// </remarks>
        /// <seealso href="https://datatracker.ietf.org/doc/html/rfc6749#section-3.3"/>
        public string Scope {
            get;
            set;
        } = string.Empty;

        /// <inheritdoc/>
        public IEnumerable<ValidationResult> Validate(ValidationContext? validationContext) {
            if (String.IsNullOrEmpty(ClientId))
                yield return new ValidationResult($"{nameof(ClientId)} muss angegeben werden.");
            if (String.IsNullOrEmpty(ClientSecret))
                yield return new ValidationResult($"{nameof(ClientSecret)} muss angegeben werden.");
            if (String.IsNullOrEmpty(Scope))
                yield return new ValidationResult($"{nameof(Scope)} muss angegeben werden.");
        }

    }

}
