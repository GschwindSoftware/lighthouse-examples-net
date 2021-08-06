namespace Gschwind.Lighthouse.Example.Models.Data {

    /// <summary>
    /// Grundstücksart
    /// </summary>
    public enum LandType {
        /// <summary>
        /// Ein- und Zweifamilienhaus
        /// </summary>
        Family,
        /// <summary>
        /// Mietwohnungsgrundstück
        /// </summary>
        Rented = 1,
        /// <summary>
        /// Wohnungs- und Teileigentum
        /// </summary>
        Leasehold = 2,
        /// <summary>
        /// Geschäftsgrundstück
        /// </summary>
        Business = 3,
        /// <summary>
        /// Gemischt genutztes Grundstück
        /// </summary>
        Mixed = 4,
        /// <summary>
        /// Sonstiges bebautes Grundstück
        /// </summary>
        Other = 5
    }

}
