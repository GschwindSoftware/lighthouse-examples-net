
namespace Gschwind.Lighthouse.Example.Models.Data {

    /// <summary>
    /// Steuerermäßigung
    /// </summary>
    public record TaxReduction : IncomeBase {

        /// <summary>
        /// Erzeugt eine neue Instanz der <see cref="TaxReduction"/>-Klasse
        /// </summary>
        public TaxReduction() =>
            ScenarioParameter = ScenarioParameter with { Death = 100 };

    }

}