namespace Gschwind.Lighthouse.Example.Models.Family {

    /// <summary>
    /// Der Partner des Kunden innerhalb einer Familie. Jede Familie darf nur einen Partner beinhalten
    /// </summary>
    public record Partner : ClientOrPartner {

        /// <summary>
        /// Wenn auf "wahr" gesetzt, wird der Partner des Kunden weder angezeigt noch in Auswertungen berücksichtigt
        /// </summary>
        public bool IsHidden {
            get;
            init;
        } = false;

    }

}