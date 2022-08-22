namespace Gschwind.Lighthouse.Example.Models.Data {

    /// <summary>
    /// Miete
    /// </summary>
    public record Rent : CashFlowBase {

        /// <summary>
        /// Erzeugt eine neue Instanz der <see cref="Rent"/>-Klasse
        /// </summary>
        public Rent() {
            CashFlows = CashFlows with { Period = Period.Monthly };
            ScenarioParameter = ScenarioParameter with { Death = 100 };
        }

    }

}
