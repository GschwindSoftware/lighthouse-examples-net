using System.Collections.Generic;
using System.Linq;

namespace Gschwind.Lighthouse.Example.Models.Data {

    /// <summary>
    /// Basisklasse für Sichteinlagen
    /// </summary>
    public abstract record DemandDeposit : CashValue {

        /// <summary>
        /// Einzahlungen
        /// </summary>
        public CashFlows Savings {
            get;
            init;
        } = new CashFlows { Period = Period.Yearly };

        /// <summary>
        /// Sondereinzahlungen
        /// </summary>
        public ICollection<DateValue> AdditionalSavings {
            get;
            init;
        } = new List<DateValue>();

        /// <summary>
        /// Auszahlungen
        /// </summary>
        public CashFlows Withdrawals {
            get;
            init;
        } = new CashFlows { Period = Period.Yearly };

        /// <summary>
        /// Sonderauszahlungen
        /// </summary>
        public ICollection<DateValue> AdditionalWithdrawals {
            get;
            init;
        } = new List<DateValue>();

        /// <summary>
        /// Gebühren
        /// </summary>
        public PeriodValues Fees {
            get;
            init;
        } = new PeriodValues { Period = Period.Yearly };

    }

}