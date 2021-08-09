
namespace Gschwind.Lighthouse.Example.Models.Data {

    /// <summary>
    /// Vorgang Festgeld
    /// </summary>
    public record TimeMoney : TimeDeposit {

        /// <summary>
        /// Erzeugt eine neue Instanz der <see cref="TimeMoney"/>-Klasse
        /// </summary>
        public TimeMoney() {
            IsCumulative = false;
            InterestPeriod = Period.Yearly;
        }

    }

}
