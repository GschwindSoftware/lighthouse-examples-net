using System;
using System.Collections.Generic;
using System.Linq;

namespace Gschwind.Lighthouse.Example.Models.Data {

    /// <summary>
    /// Private Kapitalversicherung
    /// </summary>
    public abstract record PrivateCapitalInsurance : PrivatePension {

        /// <summary>
        /// Versicherte Person
        /// </summary>
        public Guid InsuredPerson {
            get;
            init;
        } = Guid.Empty;

        /// <summary>
        /// Art der Leistungsauszahlung (Einmalige Kapitalleistung oder monatliche Rente)
        /// </summary>
        public InsurancePayoutType InsurancePayoutType {
            get;
            init;
        } = InsurancePayoutType.CapitalPayment;

        /// <summary>
        /// Kapitalleistung
        /// </summary>
        public double CapitalPayment {
            get;
            init;
        }

        /// <summary>
        /// Weitere Leistungen
        /// </summary>
        public ICollection<DateValue> AdditionalPayments {
            get;
            init;
        } = new List<DateValue>();

        /// <summary>
        /// Bezug
        /// </summary>
        public Guid Reference {
            get;
            init;
        } = Guid.Empty;

        /// <summary>
        /// Art der Leistungen im Todesfall
        /// </summary>
        public DeathPaymentType DeathPaymentType {
            get;
            init;
        } = DeathPaymentType.None;

        /// <summary>
        /// Todesfallleistung
        /// </summary>
        public ICollection<DateValue> DeathBenefit {
            get;
            init;
        } = new List<DateValue>();

        /// <summary>
        /// 1. Begünstiger im Todesfall
        /// </summary>
        public Guid Beneficiary1 {
            get;
            init;
        } = Guid.Empty;

        /// <summary>
        /// 2. Begünstiger im Todesfall
        /// </summary>
        public Guid Beneficiary2 {
            get;
            init;
        } = Guid.Empty;

        /// <summary>
        /// 3. Begünstiger im Todesfall
        /// </summary>
        public Guid Beneficiary3 {
            get;
            init;
        } = Guid.Empty;

        /// <summary>
        /// 4. Begünstiger im Todesfall
        /// </summary>
        public Guid Beneficiary4 {
            get;
            init;
        } = Guid.Empty;

    }

}
