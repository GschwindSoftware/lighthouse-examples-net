using System;

namespace Gschwind.Lighthouse.Example.Models.Data {

    /// <summary>
    /// Rente aus Versorgungswerk
    /// </summary>
    public record ProfessionalPension : StatePension {

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
        /// Versicherungsbeginn
        /// </summary>
        public DateTime InceptionDate {
            get;
            init;
        } = new DateTime(DateTime.Now.Year, 1, 1);

        /// <summary>
        /// Kapitalleistung
        /// </summary>
        public double CapitalPayment {
            get;
            init;
        }

        /// <summary>
        /// Art der Leistungsauszahlung (Einmalige Kapitalleistung oder monatliche Rente)
        /// </summary>
        public InsurancePayoutType InsurancePayoutType {
            get;
            init;
        } = InsurancePayoutType.MonthlyPension;

        /// <summary>
        /// Arbeitgeberanteil in %
        /// </summary>
        public double EmployersRefundRate {
            get;
            init;
        }

        /// <summary>
        /// Ist die Kapitalleistung steuerlich relevant?
        /// </summary>
        public bool IsTaxRelevant {
            get;
            init;
        } = true;

        /// <summary>
        /// Besteuerung der Kapitalleistung mit Fünftelregelung ?
        /// </summary>
        public bool IsFifthPartRule {
            get;
            init;
        }

        /// <summary>
        /// Automatisch 60% der Altersrente nehmen
        /// </summary>
        public bool AutomaticWidowsPension {
            get;
            init;
        } = true;

        /// <summary>
        /// Erwerbsunfähigkeitsrente
        /// </summary>
        public double DisabilityPension {
            get;
            init;
        }

        /// <summary>
        /// Wird die Altersrente reduziert
        /// </summary>
        public bool HasReducedPension {
            get;
            init;
        }

        /// <summary>
        /// Reduzierte Altersrente nach Erwerbsunfähigkeit
        /// </summary>
        public double ReducedPension {
            get;
            init;
        }

        /// <summary>
        /// Reduzierte Kapitalleistung bei Erwerbsunfähigkeit
        /// </summary>
        public double ReducedCapitalPayment {
            get;
            init;
        }

        /// <summary>
        /// Beitragsbefreiung im BU-Fall
        /// </summary>
        public bool PremiumContribution {
            get;
            init;
        }

    }

}
