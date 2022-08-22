namespace Gschwind.Lighthouse.Example.Models.Data {

    /// <summary>
    /// Wert zu einem Datum
    /// </summary>
    public record DateValue {

        /// <summary>
        /// Datum
        /// </summary>
        public DateTime Date {
            get;
            init;
        } = new(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);

        /// <summary>
        /// Betrag
        /// </summary>
        public double Value {
            get;
            init;
        }

        /// <summary>
        /// Typ der Wiederholung
        /// </summary>
        public RepeatType Interval {
            get;
            init;
        } = RepeatType.Single;

        /// <summary>
        /// Anzahl Wiederholung
        /// </summary>
        public int Count {
            get;
            init;
        } = 1;
    }

}
