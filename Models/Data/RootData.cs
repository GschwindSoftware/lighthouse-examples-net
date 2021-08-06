
namespace Gschwind.Lighthouse.Example.Models.Data {

    /// <summary>
    /// Hauptvorgang
    /// </summary>
    public abstract record RootData : PlanData {

        /// <summary>
        /// Nachrichtliche Informationen
        /// </summary>
        public Informations Informations {
            get;
            init;
        } = new Informations();

        /// <summary>
        /// Besitzer
        /// </summary>
        public Owner Owner {
            get;
            init;
        } = new Owner();

    }

}