using Gschwind.Lighthouse.Example.Api;
using Gschwind.Lighthouse.Example.Authentication;
using Gschwind.Lighthouse.Example.Serialization;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Refit;

namespace Microsoft.Extensions.DependencyInjection.Extensions {

    /// <summary>
    /// Stellt Erweiterungsmethoden für <see cref="IServiceCollection"/> zur Verfügung, um die Financial Lighthouse API zu registrieren
    /// </summary>
    internal static class ApiServiceCollectionExtensions {

        /// <summary>
        /// Fügt die Services der Financial Lighthouse API zur <see cref="IServiceCollection"/> hinzu
        /// </summary>
        /// <param name="services">Die <see cref="IServiceCollection"/>, zu der die Services hinzugefügt werden.</param>
        /// <param name="configuration">Die <see cref="IConfiguration">Konfiguration</see> der Applikation.</param>
        /// <returns>
        /// Die übergebene <see cref="IServiceCollection"/>, sodass mehrere Aufrufe verknüpft werden können
        /// </returns>
        internal static IServiceCollection AddLighthouseApi(this IServiceCollection services, IConfiguration configuration) {
            services
                .AddTransient<LighthouseApi>()
                .AddTransient<ClientCredentialsHandler>();

            var settings = new JsonSerializerSettings {
                ContractResolver = new LighthouseContractResolver(),
                Converters = { new StringEnumConverter() }
            };

            foreach (var apiType in new[] { typeof(IReportingApi), typeof(IPlanApi) })
                services
                    .AddSingleton(settings)
                    // Financial Lighthouse API Client
                    .AddRefitClient(apiType, new RefitSettings {
                        // Json Konventionen
                        ContentSerializer = new NewtonsoftJsonContentSerializer(settings)
                    })
                    .AddHttpMessageHandler<ClientCredentialsHandler>()
                    .ConfigureHttpClient((services, client) =>
                        client.BaseAddress = new("https://api.financial-lighthouse.de/fin")
                    );

            // Authentifizierung mit OAuth
            services
                .Configure<OAuthOptions>(configuration.GetSection("OAuth"))
                .AddHttpClient("oauth")
                .ConfigureHttpClient((services, client) =>
                    client.BaseAddress = new("https://auth.financial-lighthouse.de/")
                );

            return services;
        }

    }

}
