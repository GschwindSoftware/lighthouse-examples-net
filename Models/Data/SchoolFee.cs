namespace Gschwind.Lighthouse.Example.Models.Data {

    /// <summary>
    /// Schulgeld
    /// </summary>
    public record SchoolFee : CashFlowBase {

        /// <summary>
        /// Erzeugt eine neue Instanz der <see cref="SchoolFee"/>-Klasse
        /// </summary>
        public SchoolFee() =>
            ScenarioParameter = ScenarioParameter with { Death = 100 };

    }

}
