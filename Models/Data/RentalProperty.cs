using System;
using System.Collections.Generic;
using System.Linq;

namespace Gschwind.Lighthouse.Example.Models.Data {

    /// <summary>
    /// Fremdgenutzte Immobilie
    /// </summary>
    public record RentalProperty : PropertyBase {

        /// <summary>
        /// Nutzungsart
        /// </summary>
        public string TypeOfUse {
            get;
            init;
        } = "Sonstige Immobilie";

        /// <summary>
        /// Mieteinnahmen
        /// </summary>
        public ICollection<RentalIncome> RentalIncomes {
            get;
            init;
        } = new List<RentalIncome>();

        /// <summary>
        /// Einkunftsart der Mieteinnahmen
        /// </summary>
        public IncomeType RentalIncomeType {
            get;
            init;
        } = IncomeType.LettingAndLeasing;

        /// <summary>
        /// Besteuerung
        /// </summary>
        public TaxableType TaxableType {
            get;
            init;
        } = TaxableType.Domestic;

        /// <summary>
        /// Abschreibungsart
        /// </summary>
        public AmortizationType AmortizationType {
            get;
            init;
        } = AmortizationType.Auto;

        /// <summary>
        /// Start der Abschreibung
        /// </summary>
        public DateTime AmortizationStart {
            get;
            init;
        } = new DateTime(DateTime.Now.Year, 1, 1);

        /// <summary>
        /// Bemessungsgrundlage automatisch berechnen
        /// </summary>
        public bool AutoAmortizationValue {
            get;
            init;
        } = true;

        /// <summary>
        /// Bemessungsgrundlage für Abschreibung
        /// </summary>
        public double AmortizationValue {
            get;
            init;
        }

        /// <summary>
        /// Sanierungen
        /// </summary>
        public ICollection<Renovation> Renovations {
            get;
            init;
        } = new List<Renovation>();

    }

}
