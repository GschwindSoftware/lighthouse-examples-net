namespace Gschwind.Lighthouse.Example.Models.Reports {

    /// <summary>
    /// Ein Finanzbericht
    /// </summary>
    public record Report {

        /// <summary>
        /// Kategorien, die zusammenhängende Datenpunkte beschreiben. Die n-te Kategorie entspricht
        /// dem n-ten Datenpunkt in jedem Element der `Serie`
        /// </summary>
        public IEnumerable<ReportCategory> Categories {
            get;
            private set;
        } = Array.Empty<ReportCategory>();

        /// <summary>
        /// Die Reihe mit den Daten des Berichts
        /// </summary>
        public IEnumerable<HierarchicalDataSeries> Series {
            get;
            private set;
        } = Array.Empty<HierarchicalDataSeries>();

    }

}
