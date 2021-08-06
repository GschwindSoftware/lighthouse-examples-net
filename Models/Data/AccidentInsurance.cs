namespace Gschwind.Lighthouse.Example.Models.Data {

    /// <summary>
    /// Unfallversicherung
    /// </summary>
    public record AccidentInsurance : PersonalInsurance {

        /// <summary>
        /// Deckungssumme
        /// </summary>
        public double InsuredSum {
            get;
            init;
        }

        /// <summary>
        /// Progression bei der Invalidiät
        /// </summary>
        public int InvalidityProgression {
            get;
            init;
        }

        /// <summary>
        /// Festbetrag
        /// </summary>
        public double FixedAmount {
            get;
            init;
        }

        /// <summary>
        /// Höhe Unfallrente
        /// </summary>
        public double AccidentPension {
            get;
            init;
        }

        /// <summary>
        /// Rückerstattungen bei unfallfreiem Verlauf
        /// </summary>
        public MarketValues Refunds {
            get;
            init;
        } = new MarketValues();

        /// <summary>
        /// Todesfallleistung
        /// </summary>
        public double DeathBenefit {
            get;
            init;
        }

        /// <summary>
        /// Begünstigter im Todesfall
        /// </summary>
        public string DeathBeneficiary {
            get;
            init;
        } = "KEINER";

    }

}
