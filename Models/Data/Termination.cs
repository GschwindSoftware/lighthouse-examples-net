using System;

namespace Gschwind.Lighthouse.Example.Models.Data {

    /// <summary>
    /// Vorgang beenden
    /// </summary>
    public record Termination : RootData {

        /// <summary>
        /// Zeitpunkt der Beendigung
        /// </summary>
        public DateTime TerminatonDate {
            get;
            init;
        } = new(DateTime.Now.Year + 1, 1, 1);

        /// <summary>
        /// Der Vorgang der beendet wird
        /// </summary>
        public Guid Reference {
            get;
            init;
        } = Guid.Empty;

        /// <summary>
        /// Der Verkaufspreis wird automatisch berechnet (kann nur bei Sachwerten geändert werden)
        /// </summary>
        public bool AutomaticCalculation {
            get;
            init;
        } = true;

        /// <summary>
        /// Der manuelle Verkaufspreis, falls Verkaufswert nicht automatisch berechnet wird
        /// </summary>
        public double SellingPrice {
            get;
            init;
        }

    }

}
