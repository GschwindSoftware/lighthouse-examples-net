namespace Gschwind.Lighthouse.Example.Models.Data {

    /// <summary>
    /// Leistungen im Todesfall
    /// </summary>
    public enum DeathPaymentType {
        /// <summary>
        /// Keine
        /// </summary>
        None,
        /// <summary>
        /// Todesfallleistung
        /// </summary>
        DeathBenefit = 1,
        /// <summary>
        /// Hinterbliebenenrente
        /// </summary>
        SurvivorsPension = 5,
        /// <summary>
        /// Beitragsrückgewähr
        /// </summary>
        PremiumRefund = 6,
        /// <summary>
        /// Rückkaufwert
        /// </summary>
        RepurchaseValue = 7
    }

}
