namespace Gschwind.Lighthouse.Example.Models.Data {

    /// <summary>
    /// Einkunft aus Vermietung und Verpachtung
    /// </summary>
    public record LettingAndLeasingIncome : CashFlowBase {

        /// <summary>
        /// Erzeugt eine neue Instanz der <see cref="LettingAndLeasingIncome"/>-Klasse
        /// </summary>
        public LettingAndLeasingIncome() {
            CashFlows = CashFlows with { Period = Period.Monthly };
            ScenarioParameter = ScenarioParameter with { Death = 100 };
        }

    }

}
