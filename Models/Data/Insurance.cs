namespace Gschwind.Lighthouse.Example.Models.Data {

    /// <summary>
    /// Versicherung
    /// </summary>
    public abstract record Insurance : PlanData {

        /// <summary>
        /// Name der Versicherungsgesellschaft
        /// </summary>
        public string InsuranceCompany {
            get;
            init;
        } = String.Empty;

        /// <summary>
        /// Vertragsnummer
        /// </summary>
        public string ContractNumber {
            get;
            init;
        } = String.Empty;

        /// <summary>
        /// Versicherungsbeiträge
        /// </summary>
        public CashFlows Premium {
            get;
            init;
        } = new() { Period = Period.Monthly };

        /// <summary>
        /// Versicherungsbeginn
        /// </summary>
        public DateTime InsuranceStart {
            get;
            init;
        } = new(DateTime.Now.Year, 1, 1);

        /// <summary>
        /// Versicherungsende
        /// </summary>
        public Moment Termination {
            get;
            init;
        } = new();

    }

}
