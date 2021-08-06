namespace Gschwind.Lighthouse.Example.Models.Data {

    /// <summary>
    /// Art des Zeitpunktes
    /// </summary>
    public enum MomentType {
        /// <summary>
        /// An einem bestimmten Datum
        /// </summary>
        AtDate,
        /// <summary>
        /// Nie
        /// </summary>
        Never = 1,
        /// <summary>
        /// Bei Renteneintritt
        /// </summary>
        AtRetirement = 2,
        /// <summary>
        /// Zu einem bestimmten Alter
        /// </summary>
        AtAge = 6
    }

}
