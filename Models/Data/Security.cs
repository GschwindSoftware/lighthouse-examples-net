using System;
using System.Collections.Generic;
using System.Linq;

namespace Gschwind.Lighthouse.Example.Models.Data {

    /// <summary>
    /// Wertpapier
    /// </summary>
    public record Security : SecurityBase {

        /// <summary>
        /// Der Typ des Wertpapieres
        /// </summary>
        public SecurityType SecurityType {
            get;
            init;
        } = SecurityType.Stock;

        /// <summary>
        /// Die ISIN-Nummer des Wertpapieres
        /// </summary>
        public string Isin {
            get;
            init;
        } = String.Empty;

        /// <summary>
        /// Wertstellungsdatum
        /// </summary>
        public DateTime ValueDate {
            get;
            init;
        } = DateTime.Now.Date;

        /// <summary>
        /// Stückzahl bei Aktien / Nominalbetrag bei Anleihen
        /// </summary>
        public double Quantity {
            get;
            init;
        }

        /// <summary>
        /// Kurs
        /// </summary>
        public double SecurityPrice {
            get;
            init;
        }

        /// <summary>
        /// Name des Depots
        /// </summary>
        public string DepotName {
            get;
            init;
        } = String.Empty;

        /// <summary>
        /// Ausschüttungen
        /// </summary>
        public ICollection<PercentValue> Dividends {
            get;
            init;
        } = new List<PercentValue>();

        /// <summary>
        /// Wertsteigerungen
        /// </summary>
        public ICollection<PercentValue> Appreciations {
            get;
            init;
        } = new List<PercentValue>();

        /// <summary>
        /// Muss Wertsteigerung und Dividende versteuert werden?
        /// </summary>
        public bool IsTaxable {
            get;
            init;
        } = true;

        /// <summary>
        /// Wiederanlage der Gewinne
        /// </summary>
        public bool ReinvestDividends {
            get;
            init;
        } = false;

        /// <summary>
        /// Die Regionen des Wertpapieres
        /// </summary>
        public ICollection<Region> Regions {
            get;
            init;
        } = new List<Region>();

        /// <summary>
        /// Der Industriesektor des Wertpapieres
        /// </summary>
        public ICollection<Industry> Industries {
            get;
            init;
        } = new List<Industry>();

        /// <summary>
        /// Risikostufe
        /// </summary>
        public RiskLevel RiskLevel {
            get;
            init;
        } = RiskLevel.NotCritical;

        /// <summary>
        /// Rating
        /// </summary>
        public string? Rating {
            get;
            init;
        }

        /// <summary>
        /// Agio beim Kauf
        /// </summary>
        public double Agio {
            get;
            init;
        }

        /// <summary>
        /// Fälligkeitsdatum
        /// </summary>
        public DateTime MaturityDate {
            get;
            init;
        } = new DateTime(DateTime.Now.Year+10, 12, 31);

        /// <summary>
        /// Kauf
        /// </summary>
        public Buying Buying {
            get;
            init;
        } = new Buying();

        /// <summary>
        /// Dividendenausschüttung
        /// </summary>
        public DateTime DividendPayout {
            get;
            init;
        } = new DateTime(DateTime.Now.Year, 12, 31);

        /// <summary>
        /// Einzahlungen
        /// </summary>
        public CashFlows Savings {
            get;
            init;
        } = new CashFlows { Period = Period.Yearly };

        /// <summary>
        /// Sondereinzahlungen
        /// </summary>
        public ICollection<DateValue> AdditionalSavings {
            get;
            init;
        } = new List<DateValue>();

    }

}
