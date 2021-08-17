
namespace Gschwind.Lighthouse.Example.Models.Data {

    /// <summary>
    /// Vorgang Sparbrief
    /// </summary>
    public record SavingsBond : TimeDeposit {

        /// <summary>
        /// Erzeugt eine neue Instanz der <see cref="SavingsBond"/>-Klasse
        /// </summary>
        public SavingsBond() =>
            (IsCumulative, InterestPeriod) = (false, Period.Yearly);

    }

}
