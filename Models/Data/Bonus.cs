using System;

namespace Gschwind.Lighthouse.Example.Models.Data {

    /// <summary>
    /// Bonus
    /// </summary>
    public record Bonus : SubData {

        /// <summary>
        /// Bonuszahlungen
        /// </summary>
        public CashFlows CashFlows {
            get;
            init;
        } = new CashFlows { Period = Period.Yearly };

        /// <summary>
        /// Monat der Zahlung
        /// </summary>
        public int PaymentMonth {
            get;
            init;
        } = 12;

    }

}