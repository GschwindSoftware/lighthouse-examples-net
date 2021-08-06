namespace Gschwind.Lighthouse.Example.Models.Data {

    /// <summary>
    /// Abschreibungstyp
    /// </summary>
    public enum AmortizationType {
        /// <summary>
        /// Keine Abschreibung
        /// </summary>
        None,
        /// <summary>
        /// Automatisch
        /// </summary>
        Auto = 1,
        /// <summary>
        /// Degressiv 1
        /// </summary>
        Degressiv1 = 2,
        /// <summary>
        /// Degressiv 2
        /// </summary>
        Degressiv2 = 3,
        /// <summary>
        /// Linear über 40 Jahre
        /// </summary>
        Linear40Years = 4,
        /// <summary>
        /// Linear über 50 Jahre
        /// </summary>
        Linear50Years = 5,
        /// <summary>
        /// Linear über 25 Jahre
        /// </summary>
        Linear25Years = 6,
        /// <summary>
        /// Linear über 5 Jahre
        /// </summary>
        Linear5Years = 7,
        /// <summary>
        /// Denkmalgeschützes Gebäude
        /// </summary>
        HistoricProtected = 8,
        /// <summary>
        /// Degressiv 3
        /// </summary>
        Degressiv3 = 9,
        /// <summary>
        /// Degressiv 4
        /// </summary>
        Degressiv4 = 10,
        /// <summary>
        /// Baudenkmal ab 2004
        /// </summary>
        ForeignHistoricBuildingSince2004 = 11,
        /// <summary>
        /// Baudenkmal eigengenutzt ab 2004
        /// </summary>
        OwnerHistoricBuildingSince2004 = 12,
        /// <summary>
        /// Linear über 33 Jahre
        /// </summary>
        Linear33Years = 13,
        /// <summary>
        /// Baudenkmal eigengenutzt vor 2004
        /// </summary>
        OwnerHistoricBuildingBefore2004 = 14,
        /// <summary>
        /// Sofortabschreibung
        /// </summary>
        Immediately = 15,
        /// <summary>
        /// Manuelle Eingabe
        /// </summary>
        Manuell = 99
    }

}
