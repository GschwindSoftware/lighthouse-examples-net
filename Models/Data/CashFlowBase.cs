namespace Gschwind.Lighthouse.Example.Models.Data {

    /// <summary>
    /// Basisklasse für die Liquidität
    /// </summary>
    public abstract record CashFlowBase : PlanData {

        /// <summary>
        /// Zahlungen
        /// </summary>
        public CashFlows CashFlows {
            get;
            init;
        } = new() { Period = Period.Yearly };

        /// <summary>
        /// Ende der Zahlungen
        /// </summary>
        public Moment Termination {
            get;
            init;
        } = new();

        /// <summary>
        /// Risiko-Szenario
        /// </summary>
        public ScenarioParameter ScenarioParameter {
            get;
            init;
        } = new();

    }

}
