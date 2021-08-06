using System;
using Gschwind.Lighthouse.Example.Models.Data;

namespace Gschwind.Lighthouse.Example.Models.Reports {

    /// <summary>
    /// Parameter einer Auswertung
    /// </summary>
    public record ReportParameters {

        /// <summary>
        /// Eine Liste mit eindeutigen Schlüsseln von Familienmitglieder, deren Vorgänge ausgewertet werden. Falls
        /// keine Schlüssel angegeben werden, muss der Parameter `Portfolio` belegt sein
        /// </summary>
        public OwnerType PersonsToEvaluate {
            get;
            init;
        } = OwnerType.Both;

        /// <summary>
        /// Startdatum, falls Dates nicht gesetzt wurde
        /// </summary>
        public DateTime? StartDate {
            get;
            init;
        }

        /// <summary>
        /// Enddatum, falls Dates nicht gesetzt wurde
        /// </summary>
        public DateTime? EndDate {
            get;
            init;
        }

        /// <summary>
        /// Zeitraum, falls Dates nicht gesetzt wurde
        /// </summary>
        public Period Period {
            get;
            init;
        } = Period.Yearly;

        /// <summary>
        /// Der Szenariotyp
        /// </summary>
        public ScenarioType ScenarioType {
            get;
            init;
        } = ScenarioType.Standard;

        /// <summary>
        /// Der Index einer Empfehlungsliste zur Berücksichtigung von Empfehlungen innerhalb der Auswertung
        /// Wird dieser nicht angegeben, werden vorhandene Empfehlungen nicht berücksichtigt
        /// </summary>
        public int RecommendationIndex {
            get;
            init;
        }

        /// <summary>
        /// Der eindeutige Schlüssel eines Vorgangs für die Auswertung
        /// </summary>
        public Guid Item {
            get;
            init;
        } = Guid.Empty;

        /// <summary>
        /// Die Wurzel der Auswertung
        /// </summary>
        public string Root {
            get;
            init;
        } = "";

        /// <summary>
        /// Gibt an, ob Null-Zeilen angezeigt werden sollen
        /// </summary>
        public bool HideEmptyLines {
            get;
            init;
        } = true;

        /// <summary>
        /// Die maximale Tiefe der hierarchischen Berichtsdaten
        /// </summary>
        public int Depth {
            get;
            init;
        } = 3;

    }

}
