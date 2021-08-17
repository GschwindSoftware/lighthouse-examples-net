namespace Gschwind.Lighthouse.Example.Models.Reports {

    /// <summary>
    /// Beschreibt, wie Datenpunkte in einer `DataSeries` interpretiert werden
    /// </summary>
    public enum DataPointType {
        /// <summary>
        /// Datenpunkte stellen absolute Werte dar
        /// </summary>
        Double,
        /// <summary>
        /// Datenpunkte stellen absolute, ganzzahlige Werte dar
        /// </summary>
        Integer,
        /// <summary>
        /// Datenpunkte repräsentieren Prozentwerte zwischen `0` und `1`
        /// </summary>
        Percent,
        /// <summary>
        /// Datenpunkte stellen Werte in der Einheit Quadratmeter dar
        /// </summary>
        SquareMeter,
        /// <summary>
        /// Datenpunkte repräsentieren Werte in einer Währung
        /// </summary>
        Currency
    }

}
