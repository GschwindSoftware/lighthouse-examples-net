using System;

namespace Gschwind.Lighthouse.Example.Models.Data {

    /// <summary>
    /// Nachrichtliche Informationen
    /// </summary>
    public record Informations {

        /// <summary>
        /// Notizen
        /// </summary>
        public string Notes {
            get;
            init;
        } = "";

        /// <summary>
        /// Noch zu erledigen
        /// </summary>
        public string Todo {
            get;
            init;
        } = "";

        /// <summary>
        /// Letztes Änderungsdatum
        /// </summary>
        public DateTime LastChanged {
            get;
            init;
        } = DateTime.Now.Date;

        /// <summary>
        /// Letzter Benutzer
        /// </summary>
        public string LastUser {
            get;
            init;
        } = "";

    }

}