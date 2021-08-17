namespace Gschwind.Lighthouse.Example.Models.Reports {

    /// <summary>
    /// Arten von Berichtskategorien
    /// </summary>
    public enum ReportCategoryType {
        /// <summary>
        /// Datenpunkte repräsentieren einen Moment in der Zeit
        /// </summary>
        Date,
        /// <summary>
        /// Datenpunkte repräsentieren einen Zeitbereich
        /// </summary>
        Range,
        /// <summary>
        /// Datenpunkte repräsentieren einen Erben
        /// </summary>
        Heritage,
        /// <summary>
        /// Datenpunkte beziehen sich auf eine Eigenschaft eines Objekts
        /// </summary>
        DataMember
    }

}
