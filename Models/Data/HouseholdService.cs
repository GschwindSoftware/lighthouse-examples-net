using System;

namespace Gschwind.Lighthouse.Example.Models.Data {

    /// <summary>
    /// Haushaltsnahe Leistung
    /// </summary>
    public record HouseholdService : ExpenseBase {

        /// <summary>
        /// Steuerliche Berücksichtigung
        /// </summary>
        public HousehouldServiceType ServiceType {
            get;
            init;
        }

        /// <summary>
        /// Lohnanteil
        /// </summary>
        public double WageShare {
            get;
            init;
        } = 100;

        /// <summary>
        /// Erzeugt eine neue Instanz der <see cref="HouseholdService"/>-Klasse
        /// </summary>
        public HouseholdService() =>
            ScenarioParameter = ScenarioParameter with { Death = 100 };

    }

}
