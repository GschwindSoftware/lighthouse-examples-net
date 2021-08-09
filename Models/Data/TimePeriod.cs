using System;

namespace Gschwind.Lighthouse.Example.Models.Data {

    /// <summary>
    /// Zeitraum
    /// </summary>
    public record TimePeriod {

        /// <summary>
        /// Start des Zeitraums
        /// </summary>
        public DateTime StartDate {
            get;
            init;
        } = new DateTime(DateTime.Now.Year, 1, 1);

        /// <summary>
        /// Ende des Zeitraums: Typ
        /// </summary>
        public MomentType EndType {
            get;
            init;
        } = MomentType.Never;

        /// <summary>
        /// Endes des Zeitraum: Datum (bei AtDate)
        /// </summary>
        public DateTime EndDate {
            get;
            init;
        } = new DateTime(DateTime.Now.Year + 10, 1, 1);

        /// <summary>
        /// Ende des Zeitraums: Alter des Eigentümers (bei AtAge)
        /// </summary>
        public int EndAge {
            get;
            init;
        } = 65;

    }

}
