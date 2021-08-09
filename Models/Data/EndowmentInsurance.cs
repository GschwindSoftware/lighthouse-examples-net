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
        } = String.Empty;

        /// <summary>
        /// Vertragsnummer
        /// </summary>
        public string ContractNumber {
            get;
            init;
        } = String.Empty;

        /// <summary>
        /// Versicherungsbeginn
        /// </summary>
        public DateTime InceptionDate {
            get;
            init;
        } = new(DateTime.Now.Year, 1, 1);

        /// <summary>
        /// Risikobeiträge
        /// </summary>
        public CashFlows Premium {
            get;
            init;
        } = new() { Period = Period.Monthly };

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
        } = new() { Period = Period.Monthly };

        /// <summary>
        /// Leistungszeitpunkt
        /// </summary>
        public Moment PayoutMoment {
            get;
            init;
        } = new() { Type = MomentType.AtRetirement };

        /// <summary>
        /// Monatliche Rente
        /// </summary>
        public double Pension {
            get;
            init;
        }

        /// <summary>
        /// Jährliche Steigerung der Rente in %
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
        } = new();

    }

}
