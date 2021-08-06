
namespace Gschwind.Lighthouse.Example.Models.Data {

    /// <summary>
    /// Personengesellschaft
    /// </summary>
    public abstract record CompanyBase : RealValue {

        /// <summary>
        /// Steuerliche Bewertung der Gesellschaft
        /// </summary>
        public CompanyValuation CompanyValuation {
            get;
            init;
        } = new CompanyValuation();

    }

}