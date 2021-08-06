using System;

namespace Gschwind.Lighthouse.Example.Models.Data {

    /// <summary>
    /// Private Pflegeversicherung
    /// </summary>
    public record PrivateNursingCareInsurance : PrivateSocialInsurance {

        /// <summary>
        /// Fällt der Zuschuss im Rentenalter weg??
        /// </summary>
        public bool GrantEndsAtPension {
            get;
            init;
        } = true;

    }

}