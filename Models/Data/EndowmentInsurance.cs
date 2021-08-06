using System;

namespace Gschwind.Lighthouse.Example.Models.Data {

    /// <summary>
    /// Private Altersvorsorge
    /// </summary>
    public abstract record EndowmentInsurance : PensionInsurance {

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
        /// Versicherungsbeginn
        /// </summary>
        public DateTime InceptionDate {
            get;
            init;
        } = new DateTime(DateTime.Now.Year, 1, 1);

        /// <summary>
        /// Risikobeiträge
        /// </summary>
        public CashFlows Premium {
            get;
            init;
        } = new CashFlows { Period = Period.Monthly };

        /// <summary>
        /// Risikostufe
        /// </summary>
        public RiskLevel RiskLevel {
            get;
            init;
        } = RiskLevel.None;


        /// <summary>
        /// Kapitalbeiträge
        /// </summary>
        public CashFlows CapitalPremium {
            get;
            init;
        } = new CashFlows { Period = Period.Monthly };

        /// <summary>
        /// Leistungszeitpunkt
        /// </summary>
        public Moment PayoutMoment {
            get;
            init;
        } = new Moment { Type = MomentType.AtRetirement };


        /// <summary>
        /// Monatliche Rente
        /// </summary>
        public double Pension {
            get;
            init;
        }

        /// <summary>
        /// Monatliche Rente
        /// </summary>
        public double PensionIncrease {
            get;
            init;
        }

        /// <summary>
        /// Erwerbsunfähigkeitszusatzversicherung
        /// </summary>
        public ComplementaryDisabilityInsurance DisabilityInsurance {
            get;
            init;
        } = new ComplementaryDisabilityInsurance();

    }
}
