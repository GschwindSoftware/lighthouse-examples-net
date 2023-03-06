namespace System;

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

    /// <summary>
    /// Gibt das Ende des Tages eines Datums zurück.
    /// </summary>
    /// <param name="dt">Datum, dessen Tagesende zurückgegeben werden soll.</param>
    /// <returns>
    /// Ein <see cref="DateTime"/>-Objekt, das das Ende des Tages des übergebenen Datums enthält.
    /// </returns>
    public static DateTime EndOfDay(this DateTime dt) =>
        new(dt.Year, dt.Month, dt.Day, 23, 59, 59, 999);

    /// <summary>
    /// Gibt das Ende des Jahres eines Datums zurück.
    /// </summary>
    /// <param name="dt">Datum, dessen Jahresende zurückgegeben werden soll.</param>
    /// <returns>
    /// Ein <see cref="DateTime"/>-Objekt, das das Ende des Jahres des übergebenen Datums enthält.
    /// </returns>
    public static DateTime EndOfYear(this DateTime dt) =>
        EndOfDay(new DateTime(dt.Year, 12, 31));

}
