using System;

namespace Gschwind.Lighthouse.Example.Models.Plans.Settings {

    /// <summary>
    /// Vermächtnis
    /// </summary>
    public record Legacy {

        /// <summary>
        /// ID der Person
        /// </summary>
        public Guid PersonId {
            get;
            init;
        } = Guid.Empty;

        /// <summary>
        /// Name des Vermächtnisnehmers
        /// </summary>
        public string PersonName {
            get;
            init;
        } = "";

        /// <summary>
        /// Vermächtnistyp
        /// </summary>
        public LegacyType Type {
            get;
            init;
        } = LegacyType.Cash;

        /// <summary>
        /// Vorgang bei Stückvermächtnis
        /// </summary>
        public Guid FinanceId {
            get;
            init;
        } = Guid.Empty;

        /// <summary>
        /// Anteil am Vermächtnis
        /// </summary>
        public double Quote {
            get;
            init;
        } = 100;

        /// <summary>
        /// Wert beim Geldvermächtnis
        /// </summary>
        public double Value {
            get;
            init;
        }

        /// <summary>
        /// Kürzung nach §2324 BGB zulässig
        /// </summary>
        public bool HasReduction {
            get;
            init;
        } = true;

    }

}
