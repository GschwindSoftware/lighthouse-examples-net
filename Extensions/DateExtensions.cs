namespace System {

    /// <summary>
    /// Stellt Erweiterungsmethoden für <see cref="DateTime"/> zur Verfügung
    /// </summary>
    internal static class DateExtensions {

        /// <summary>
        /// Gibt den Anfang des Monats eines Datums zurück
        /// </summary>
        /// <param name="dt">Das untersuchte Datum</param>
        /// <returns>Den Anfang des Monats des übergebenen Datums</returns>
        internal static DateTime StartOfMonth(this DateTime dt) =>
            new(dt.Year, dt.Month, 1, 0, 0, 0);

    }

}
