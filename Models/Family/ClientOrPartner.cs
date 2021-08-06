namespace Gschwind.Lighthouse.Example.Models.Family {

    /// <summary>
    /// Basiseigenschaften des Kunden bzw. Partners innerhalb der Familie
    /// </summary>
    public abstract record ClientOrPartner : FamilyMember {

        /// <summary>
        /// Gesetzliche Versicherungen
        /// </summary>
        public StateInsurances StateInsurances {
            get;
            init;
        } = new();

        /// <summary>
        /// Krankenversicherung
        /// </summary>
        public HealthInsurance HealthInsurance {
            get;
            init;
        } = new();

        /// <summary>
        /// Angabe, ob die Person zur Zahlung von Kirchensteuer verpflichtet ist
        /// </summary>
        public bool ChurchTaxDuty {
            get;
            init;
        } = true;

        /// <summary>
        /// Berufsgruppe
        /// </summary>
        public OccupationalGroup OccupationalGroup {
            get;
            init;
        } = OccupationalGroup.Employee;

        /// <summary>
        /// Alter bei Renteneintritt
        /// </summary>
        public double? RetirementAge {
            get;
            init;
        }

        /// <summary>
        /// Lebenserwartung
        /// </summary>
        public double? LifeExpection {
            get;
            init;
        }

    }

}
