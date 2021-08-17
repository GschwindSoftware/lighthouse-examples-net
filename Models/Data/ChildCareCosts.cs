using System;

namespace Gschwind.Lighthouse.Example.Models.Data {

    /// <summary>
    /// Kinderbetreuungskosten
    /// </summary>
    public record ChildCareCosts : CashFlowBase {

        /// <summary>
        /// Bis zum Alter des Kindes
        /// </summary>
        public int ChildAge {
            get;
            init;
        } = 14;

        /// <summary>
        /// ID des Kindes
        /// </summary>
        public Guid ChildId {
            get;
            init;
        }

        /// <summary>
        /// Erzeugt eine neue Instanz der <see cref="ChildCareCosts"/>-Klasse
        /// </summary>
        public ChildCareCosts() =>
            ScenarioParameter = ScenarioParameter with { Death = 100 };

    }

}
