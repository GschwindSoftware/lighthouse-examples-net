
namespace Gschwind.Lighthouse.Example.Models.Data {

    /// <summary>
    /// Entgeltersatzleistung
    /// </summary>
    public record WageCompensation : CashFlowBase {

        /// <summary>
        /// Erzeugt eine neue Instanz der <see cref="WageCompensation"/>-Klasse
        /// </summary>
        public WageCompensation() =>
            CashFlows = CashFlows with { Period = Period.Monthly };

    }

}
