namespace Gschwind.Lighthouse.Example.Models.Data {

    /// <summary>
    /// Personenversicherung
    /// </summary>
    public abstract record PersonalInsurance : Insurance {

        /// <summary>
        /// Versicherte Person
        /// </summary>
        public Guid InsuredPerson {
            get;
            init;
        } = Guid.Empty;

    }

}
