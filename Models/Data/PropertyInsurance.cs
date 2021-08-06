
namespace Gschwind.Lighthouse.Example.Models.Data {

    /// <summary>
    /// Basisklasse Sachversicherung
    /// </summary>
    public abstract record PropertyInsurance : Insurance {

        /// <summary>
        /// Forführung der Versicherung bei Tod
        /// </summary>
        public bool ContinueOnDeath {
            get;
            init;
        } = true;
    }

}
