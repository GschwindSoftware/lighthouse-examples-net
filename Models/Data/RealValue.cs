
namespace Gschwind.Lighthouse.Example.Models.Data {

    /// <summary>
    /// Sachwert
    /// </summary>
    public abstract record RealValue : AssetBase {

        /// <summary>
        /// Verkehrswerte
        /// </summary>
        public MarketValues MarketValues {
            get;
            init;
        } = new MarketValues();

        /// <summary>
        /// Kauf
        /// </summary>
        public Buying Buying {
            get;
            init;
        } = new Buying();

        /// <summary>
        /// Verkauf
        /// </summary>
        public Selling Selling {
            get;
            init;
        } = new Selling();

    }

}