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
        Partner = 1,
        /// <summary>
        /// Der Freibetrag wird zwischen Kunde und Partner hälftig aufgeteilt
        /// </summary>
        Both = 2,
        /// <summary>
        /// Der Kunde bekommt den halben Freibetrag
        /// </summary>
        ClientHalf = 3,
        /// <summary>
        /// Der Partner bekommt den halben Freibetrag
        /// </summary>
        PartnerHalf = 4,
        /// <summary>
        /// Es gibt weder für Kunde noch Partner einen Freibetrag
        /// </summary>
        None = 5
    }

}
