using System;
using System.Collections.Generic;
using System.Linq;

namespace Gschwind.Lighthouse.Example.Models.Data {

    /// <summary>
    /// Untervorgang Betriebsdarlehen
    /// </summary>
    public record CompanyLoan : SubData {

        /// <summary>
        /// Darlehensnominalbetrag
        /// </summary>
        public double LoanAmount {
            get;
            init;
        }

        /// <summary>
        /// Restschuld
        /// </summary>
        public DateValue RemainingDebt {
            get;
            init;
        } = new DateValue();

        /// <summary>
        /// Nominalbetrag oder Restschuld
        /// </summary>
        public LoanAmountType AmountType {
            get;
            init;
        } = LoanAmountType.Amount;

        /// <summary>
        /// Name des Instituts
        /// </summary>
        public string Institute {
            get;
            init;
        } = "";

        /// <summary>
        /// Kontonummer
        /// </summary>
        public string AccountNumber {
            get;
            init;
        } = "";

        /// <summary>
        /// Zeitraum
        /// </summary>
        public TimePeriod TimePeriod {
            get;
            init;
        } = new TimePeriod();

        /// <summary>
        /// Darlehenstyp
        /// </summary>
        public LoanType LoanType {
            get;
            init;
        } = LoanType.Annuity;

        /// <summary>
        /// Start der Tilgung
        /// </summary>
        public DateTime RepaymentStart {
            get;
            init;
        } = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);

        /// <summary>
        /// Laufzeit des Darlehens automatisch berechnen
        /// </summary>
        public bool DurationAutomated {
            get;
            init;
        } = true;

        /// <summary>
        /// Disagio
        /// </summary>
        public double Disagio {
            get;
            init;
        } = 0;

        /// <summary>
        /// Annuität in EUR bei Annuitätendarlehen / Tilgung in EUR bei Tilgungsdarlehen
        /// </summary>
        public ICollection<DateValue> Repayments {
            get;
            init;
        } = new List<DateValue>();

        /// <summary>
        /// Tilgungsintervall
        /// </summary>
        public Period RepaymentInterval {
            get;
            init;
        } = Period.Monthly;

        /// <summary>
        /// Sondertilgungen
        /// </summary>
        public ICollection<DateValue> AdditionalRepayments {
            get;
            init;
        } = new List<DateValue>();

        /// <summary>
        /// Zinssätze in %
        /// </summary>
        public ICollection<PercentValue> InterestRates {
            get;
            init;
        } = new List<PercentValue>();

        /// <summary>
        /// Ende der Zinsbindung
        /// </summary>
        public DateTime EndOfFixedInterestRate {
            get;
            init;
        } = DateTime.Now;

        /// <summary>
        /// Zinszuschüsse
        /// </summary>
        public ICollection<DateValue> InterestGrants {
            get;
            init;
        } = new List<DateValue>();

        /// <summary>
        /// Teilauszahlungen der Darlehenssumme
        /// </summary>
        public ICollection<DateValue> LoanPayouts {
            get;
            init;
        } = new List<DateValue>();

        /// <summary>
        /// Auszahlung zu Darlehensbeginn
        /// </summary>
        public bool PayoutAutomated {
            get;
            init;
        } = true;

        /// <summary>
        /// Bereitstellungszins in %
        /// </summary>
        public double CommitmentInterestRate {
            get;
            init;
        } = 0;

        /// <summary>
        /// Anzahl Bereitsellungsfreie Monate
        /// </summary>
        public int FreeCommitmentMonths {
            get;
            init;
        } = 0;

    }

}