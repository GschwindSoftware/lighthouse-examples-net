using System;

namespace Gschwind.Lighthouse.Example.Models.Data {

    /// <summary>
    /// Dread Disease Versicherung
    /// </summary>
    public record DreadDiseaseInsurance : PersonalInsurance {

        /// <summary>
        /// Versicherungssumme
        /// </summary>
        public double InsuranceSum {
            get;
            init;
        }

    }

}