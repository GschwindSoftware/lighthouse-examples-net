using System.Collections.Generic;
using System.Linq;

namespace Gschwind.Lighthouse.Example.Models.Data {

    /// <summary>
    /// Vorgang Entnahmeplan
    /// </summary>
    public record WithdrawalPlan : CashValue {

        /// <summary>
        /// Auszahlungen
        /// </summary>
        public CashFlows Withdrawals {
            get;
            init;
        } = new();

        /// <summary>
        /// Sonderauszahlungen
        /// </summary>
        public ICollection<DateValue> AdditionalWithdrawals {
            get;
            init;
        } = new List<DateValue>();

    }

}
