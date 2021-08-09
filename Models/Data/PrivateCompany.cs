using System;
using System.Collections.Generic;
using System.Linq;

namespace Gschwind.Lighthouse.Example.Models.Data {

    /// <summary>
    /// Basisklasse für Personengesellschaft
    /// </summary>
    public abstract record PrivateCompany : CompanyBase {

        /// <summary>
        /// Gewerbesteuerhebesatz
        /// </summary>
        public double TradeTaxRate {
            get;
            init;
        } = 400;

        /// <summary>
        /// Einkommensart
        /// </summary>
        public IncomeType IncomeType {
            get;
            init;
        } = IncomeType.Business;

        /// <summary>
        /// Werden alle Gewinne ausgeschüttet ?
        /// </summary>
        public bool DistributeAllProfit {
            get;
            init;
        } = true;

        /// <summary>
        /// Gewinnausschüttung, falls nicht alle Gewinne ausgeschüttet werden
        /// </summary>
        public CashFlows ProfitDistribution {
            get;
            init;
        } = new CashFlows { Period = Period.Yearly };

        /// <summary>
        /// Kontokorrentkonto
        /// </summary>
        public AccountParticipation CurrentAccount {
            get;
            init;
        } = new AccountParticipation();

        /// <summary>
        /// Besteuerung des Verkaufs
        /// </summary>
        public Taxation SaleTaxation {
            get;
            init;
        } = Taxation.IncomeTax;

        /// <summary>
        /// Freibetrag beim Verkauf nach §16 EStG anwenden
        /// </summary>
        public bool SaleAllowance {
            get;
            init;
        }

        /// <summary>
        /// Restbuchwert beim Verkauf
        /// </summary>
        public double RemainingBookValue {
            get;
            init;
        }

        /// <summary>
        /// Gewinn automatisch aus den Details berechnet
        /// </summary>
        public bool ComputeProfit {
            get;
            init;
        } = true;

        /// <summary>
        /// Manuelle Gewinneingabe, falls ComputeProfit = false
        /// </summary>
        public CashFlows Profit {
            get;
            init;
        } = new CashFlows();

        /// <summary>
        /// Einkünfte der Gesellschaft
        /// </summary>
        public ICollection<CompanyIncome> Income {
            get;
            init;
        } = new List<CompanyIncome>();

        /// <summary>
        /// Ausgaben der Gesellschaft
        /// </summary>
        public ICollection<CompanyExpense> Expenses {
            get;
            init;
        } = new List<CompanyExpense>();

        /// <summary>
        /// Investitionen
        /// </summary>
        public ICollection<CompanyInvestment> Investments {
            get;
            init;
        } = new List<CompanyInvestment>();

        /// <summary>
        /// Darlehen
        /// </summary>
        public ICollection<CompanyLoan> Loans {
            get;
            init;
        } = new List<CompanyLoan>();

    }

}
