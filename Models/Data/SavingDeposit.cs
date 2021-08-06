using System.Collections.Generic;
using System.Linq;

namespace Gschwind.Lighthouse.Example.Models.Data {

    /// <summary>
    /// Vorgang Spareinlage
    /// </summary>
    public abstract record SavingDeposit : CashValue {

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

    }

}