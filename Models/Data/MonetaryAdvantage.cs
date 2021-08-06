using System;

namespace Gschwind.Lighthouse.Example.Models.Data {

    /// <summary>
    /// Geldwerter Vorteil
    /// </summary>
    public record MonetaryAdvantage : SubData {

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