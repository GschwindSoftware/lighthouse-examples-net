
namespace Gschwind.Lighthouse.Example.Models.Data {

    /// <summary>
    /// Vorgang Lebensversicherung
    /// </summary>
    public record LifeInsurance : PrivateCapitalInsurance {

        /// <summary>
        /// Erzeugt eine neue Instanz der <see cref="LifeInsurance"/>-Klasse
        /// </summary>
        public LifeInsurance() =>
            InsurancePayoutType = InsurancePayoutType.CapitalPayment;

    }

}
