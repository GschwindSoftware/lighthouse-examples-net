namespace Gschwind.Lighthouse.Example.Models.Data {

    /// <summary>
    /// Einkunft aus Kapitalvermögen
    /// </summary>
    public record CapitalIncome : CashFlowBase {

        /// <summary>
        /// Art der Besteuerung
        /// </summary>
        public Taxation Taxation {
            get;
            init;
        } = Taxation.WithholdingTax;

        /// <summary>
        /// Erzeugt eine neue Instanz der <see cref="CapitalIncome"/>-Klasse
        /// </summary>
        public CapitalIncome() =>
            ScenarioParameter = ScenarioParameter with { Death = 100 };

    }

}
