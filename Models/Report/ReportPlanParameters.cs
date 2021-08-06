using Gschwind.Lighthouse.Example.Models.Plans;

namespace Gschwind.Lighthouse.Example.Models.Reports {

    /// <summary>
    /// Parameter für eine Auswertung inklusive eines Plans
    /// </summary>
    public record ReportPlanParameters : ReportParameters {

        /// <summary>
        /// Ein kompletter Plan, der für die Auswertung verwendet wird
        /// </summary>
        public Plan Plan {
            get;
            init;
        } = default!;

        /// <summary>
        /// Erzeugt eine neue Instanz der <see cref="ReportPlanParameters"/>-Klasse
        /// </summary>
        /// <param name="plan">Der Plan, der für die Auswertung verwendet wird.</param>
        public ReportPlanParameters(Plan plan) => Plan = plan;

    }

}
