using System;
using System.Collections.Generic;

namespace Gschwind.Lighthouse.Example.Models.Data {

    /// <summary>
    /// Geldwert
    /// </summary>
    public abstract record CashValue : AssetBase {

        /// <summary>
        /// Name des Instituts
        /// </summary>
        public string Institute {
            get;
            init;
        } = String.Empty;

        /// <summary>
        /// Kontonummer
        /// </summary>
        public string AccountNumber {
            get;
            init;
        } = String.Empty;

        /// <summary>
        /// Wertstellungsdatum
        /// </summary>
        public DateTime ValueDate {
            get;
            init;
        } = new(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);

        /// <summary>
        /// Kontostand
        /// </summary>
        public double AccountBalance {
            get;
            init;
        }

        /// <summary>
        /// Zeitraum
        /// </summary>
        public TimePeriod TimePeriod {
            get;
            init;
        } = new();

        /// <summary>
        /// Habenzinsen
        /// </summary>
        public ICollection<PercentValue> CreditRates {
            get;
            init;
        } = new List<PercentValue>();

        /// <summary>
        /// Sollzinsen
        /// </summary>
        public ICollection<PercentValue> DebitRates {
            get;
            init;
        } = new List<PercentValue>();

        /// <summary>
        /// Werden die Zinsen thesauriert?
        /// </summary>
        public bool IsCumulative {
            get;
            init;
        } = true;

        /// <summary>
        /// Sollen die Zinsen versteuert werden?
        /// </summary>
        public bool IsTaxable {
            get;
            init;
        } = true;

        /// <summary>
        /// Zinszahlungsintervall der Zinsen
        /// </summary>
        public Period InterestPeriod {
            get;
            init;
        }

        /// <summary>
        /// Bestand oder Neuanlage
        /// </summary>
        public InvestmentType InvestmentType {
            get;
            init;
        }

        /// <summary>
        /// Erzeugt eine neue Instanz der <see cref="CashValue"/>-Klasse
        /// </summary>
        protected CashValue() =>
            RiskLevel = RiskLevel.NotCritical;

    }

}
