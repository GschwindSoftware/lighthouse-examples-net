
namespace Gschwind.Lighthouse.Example.Models.Data {

    /// <summary>
    /// Basisklasse für die Liquidität
    /// </summary>
    public abstract record CashFlowBase : LiquidityBase {

        /// <summary>
        /// Zahlungen
        /// </summary>
        public CashFlows CashFlows {
            get;
            init;
        } = new CashFlows { Period = Period.Yearly };

        /// <summary>
        /// Ende der Zahlungen
        /// </summary>
        public Moment Termination {
            get;
            init;
        } = new Moment();

        /// <summary>
        /// Risiko-Szenario
        /// </summary>
        public ScenarioParameter ScenarioParameter {
            get;
            init;
        } = new ScenarioParameter();

    }

}
