using System;

namespace Gschwind.Lighthouse.Example.Models.Data {

    /// <summary>
    /// Stammdaten Geschlossener Fonds
    /// </summary>
    public record FundsMasterData {

        /// <summary>
        /// Datenbank-ID
        /// </summary>
        public int Id {
            get;
            init;
        }

        /// <summary>
        /// Symbol
        /// </summary>
        public string Icon {
            get;
            init;
        } = "company";

        /// <summary>
        /// Name
        /// </summary>
        public string Name {
            get;
            init;
        } = "";

        /// <summary>
        /// Emittent
        /// </summary>
        public string? Issuer {
            get;
            init;
        }

        /// <summary>
        /// Beschreibung
        /// </summary>
        public string? Description {
            get;
            init;
        }

        /// <summary>
        /// Fondsart
        /// </summary>
        public FundsType Type {
            get;
            init;
        } = FundsType.Other;

        /// <summary>
        /// Fonds Unterart
        /// </summary>
        public string SubType {
            get;
            init;
        } = String.Empty;

        /// <summary>
        /// Risikostufe
        /// </summary>
        public RiskLevel RiskLevel {
            get;
            init;
        } = RiskLevel.NotCritical;

        /// <summary>
        /// Einkunftsart
        /// </summary>
        public IncomeType IncomeType {
            get;
            init;
        } = IncomeType.Business;

        /// <summary>
        /// Rechtsform
        /// </summary>
        public FundsLegalForm LegalForm {
            get;
            init;
        } = FundsLegalForm.GmbHCoKG;

        /// <summary>
        /// Land
        /// </summary>
        public FundsCountry Country {
            get;
            init;
        } = FundsCountry.Germany;

        /// <summary>
        /// Region
        /// </summary>
        public string? Location {
            get;
            init;
        }

        /// <summary>
        /// Sollen die Marktwerte automatisch berechnet werden?
        /// </summary>
        public bool AutoMarketValues {
            get;
            init;
        } = true;

        /// <summary>
        /// Zusätzliche Informationen
        /// </summary>
        public string? Info {
            get;
            init;
        }

        /// <summary>
        /// Progressionsvorbehalt
        /// </summary>
        public bool ProgressionClause {
            get;
            init;
        }

        /// <summary>
        /// Fälligkeit
        /// </summary>
        public DateTime Maturity {
            get;
            init;
        } = new DateTime(DateTime.Now.Year + 10, 1, 1);

        /// <summary>
        /// Verlaufsdaten
        /// </summary>
        public FundsDataTable CourseData {
            get;
            init;
        } = new FundsDataTable();

        /// <summary>
        /// Prospektdaten
        /// </summary>
        public FundsDataTable BrochureData {
            get;
            init;
        } = new FundsDataTable();

    }

}
