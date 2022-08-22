namespace Gschwind.Lighthouse.Example.Models.Data {

    /// <summary>
    /// Basis für die private Kranken- und Pflegeversicherung
    /// </summary>
    public abstract record PrivateSocialInsurance : PersonalInsurance {

        /// <summary>
        /// Basisanteil in %
        /// </summary>
        public double BasicRate {
            get;
            init;
        }

        /// <summary>
        /// Art des Arbeitgeberzuschusses
        /// </summary>
        public EmployerGrantType EmployerGrantType {
            get;
            init;
        } = EmployerGrantType.Legally;

        /// <summary>
        /// Freiwilliger Arbeitgeberzuschuss in %
        /// </summary>
        public double EmployerGrantRate {
            get;
            init;
        }

    }

}
