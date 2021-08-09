
namespace Gschwind.Lighthouse.Example.Models.Data {

    /// <summary>
    /// Verbindlichkeit
    /// </summary>
    public abstract record LiabilityBase : RootData {

        /// <summary>
        /// Zeitraum
        /// </summary>
        public TimePeriod TimePeriod {
            get;
            init;
        } = new TimePeriod();

    }

}
