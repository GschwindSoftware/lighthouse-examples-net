using System;
using Newtonsoft.Json;

namespace Gschwind.Lighthouse.Example.Models.Family {

    /// <summary>
    /// Definiert eine Beziehung zwischen zwei Familienmitgliedern
    /// </summary>
    public record Relationship {

        /// <summary>
        /// Der eindeutige Schlüssel eines Familienmitgliedes
        /// </summary>
        [JsonProperty("member")]
        public Guid FamilyMemberId {
            get;
            init;
        }

        /// <summary>
        /// Die Art der Beziehung
        /// </summary>
        [JsonProperty("is")]
        public RelationshipType Type {
            get;
            init;
        }

        /// <summary>
        /// Der eindeutige Schlüssel des Familienmitglieds, zu dem die Beziehung besteht
        /// </summary>
        [JsonProperty("of")]
        public Guid RelatedFamilyMemberId {
            get;
            init;
        }

    }

}
