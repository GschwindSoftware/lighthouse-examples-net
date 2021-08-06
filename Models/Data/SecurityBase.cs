
namespace Gschwind.Lighthouse.Example.Models.Data {

    /// <summary>
    /// Wertpapierbasis
    /// </summary>
    public abstract record SecurityBase : RootData {

        /// <summary>
        /// Verkauf
        /// </summary>
        public Selling Selling {
            get;
            init;
        } = new Selling();

    }

}