namespace Gschwind.Lighthouse.Example.Models.Data {

    /// <summary>
    /// Ausländische Einkunft
    /// </summary>
    public record ForeignIncome : CashFlowBase {

        /// <summary>
        /// Einkunftsart
        /// </summary>
        public IncomeType IncomeType {
            get;
            init;
        } = IncomeType.Other;

        /// <summary>
        /// Besteuerung
        /// </summary>
        public Taxation Taxation {
            get;
            init;
        } = Taxation.ProgressionClause;

        /// <summary>
        /// Erzeugt eine neue Instanz der <see cref="ForeignIncome"/>-Klasse
        /// </summary>
        public ForeignIncome() =>
            ScenarioParameter = ScenarioParameter with { Death = 100 };

    }

}
