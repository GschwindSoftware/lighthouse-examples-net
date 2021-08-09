using System;

namespace Gschwind.Lighthouse.Example.Models.Data {

    /// <summary>
    /// Versicherung
    /// </summary>
    public abstract record Insurance : RootData {

        /// <summary>
        /// Name der Versicherungsgesellschaft
        /// </summary>
        public string InsuranceCompany {
            get;
            init;
        } = "";

        /// <summary>
        /// Vertragsnummer
        /// </summary>
        public string ContractNumber {
            get;
            init;
        } = "";

        /// <summary>
        /// Versicherungsbeiträge
        /// </summary>
        public CashFlows Premium {
            get;
            init;
        } = new CashFlows { Period = Period.Monthly };

        /// <summary>
        /// Versicherungsbeginnn
        /// </summary>
        public DateTime InsuranceStart {
            get;
            init;
        } = new DateTime(DateTime.Now.Year, 1, 1);

        /// <summary>
        /// Versicherungsende
        /// </summary>
        public Moment Termination {
            get;
            init;
        } = new Moment();

    }

}
