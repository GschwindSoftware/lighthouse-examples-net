
namespace Gschwind.Lighthouse.Example.Models.Data {

    /// <summary>
    /// Vermögen
    /// </summary>
    public abstract record AssetBase : RootData {

        /// <summary>
        /// Risikostufe
        /// </summary>
        public RiskLevel RiskLevel {
            get;
            init;
        } = RiskLevel.NotCritical;

    }

}