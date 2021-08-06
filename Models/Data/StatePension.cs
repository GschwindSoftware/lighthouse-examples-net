using System;

namespace Gschwind.Lighthouse.Example.Models.Data {

    /// <summary>
    /// Gesetzliche Altersvorsorge
    /// </summary>
    public abstract record StatePension : PensionInsurance {

        /// <summary>
        /// Beginn der Rentenzahlungen
        /// </summary>
        public Moment PayoutMoment {
            get;
            init;
        } = new Moment { Type = MomentType.AtRetirement };

        /// <summary>
        /// Stand
        /// </summary>
        public DateTime ValueDate {
            get;
            init;
        } = DateTime.Now.Date.StartOfMonth();

        /// <summary>
        /// Rentenzahlungen
        /// </summary>
        public double PensionValue {
            get;
            init;
        }

        /// <summary>
        /// Rentenzahlungen
        /// </summary>
        public double PensionIncrease {
            get;
            init;
        }

        /// <summary>
        /// Witwenrente
        /// </summary>
        public double WidowsPension {
            get;
            init;
        } = 0;

        /// <summary>
        /// Waisenrente
        /// </summary>
        public double OrphansPension {
            get;
            init;
        } = 0;

        /// <summary>
        /// Alter bis zu dem die Waisenrente gezahlt wird (in Jahren)
        /// </summary>
        public int OrphansPensionAge {
            get;
            init;
        } = 27;

    }

}