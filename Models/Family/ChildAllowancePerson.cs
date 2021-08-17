namespace Gschwind.Lighthouse.Example.Models.Family {

    /// <summary>
    /// Person, die den Kinderfreibetrag bekommt
    /// </summary>
    public enum ChildAllowancePerson {
        /// <summary>
        /// Der Kunde bekommt den gesamten Freibetrag
        /// </summary>
        Client,
        /// <summary>
        /// Der Partner bekommt den gesamten Freibetrag
        /// </summary>
        Partner,
        /// <summary>
        /// Der Freibetrag wird zwischen Kunde und Partner hälftig aufgeteilt
        /// </summary>
        Both,
        /// <summary>
        /// Der Kunde bekommt den halben Freibetrag
        /// </summary>
        ClientHalf,
        /// <summary>
        /// Der Partner bekommt den halben Freibetrag
        /// </summary>
        PartnerHalf,
        /// <summary>
        /// Es gibt weder für Kunde noch Partner einen Freibetrag
        /// </summary>
        None
    }

}
