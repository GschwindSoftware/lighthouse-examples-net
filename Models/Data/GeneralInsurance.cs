namespace Gschwind.Lighthouse.Example.Models.Data {

    /// <summary>
    /// Allgemeine Versicherung
    /// </summary>
    public record GeneralInsurance : Insurance {

        /// <summary>
        /// Ist es eine Vorsorgeaufwendung?
        /// </summary>
        public bool IsProvidentExpense {
            get;
            init;
        } = true;

        /// <summary>
        /// Deckungssumme
        /// </summary>
        public double InsuredSum {
            get;
            init;
        }

        /// <summary>
        /// Unbegrenzte Deckungssumme
        /// </summary>
        public bool IsUnlimitedInsuredSum {
            get;
            init;
        }

    }

}
