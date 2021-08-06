using System;

namespace Gschwind.Lighthouse.Example.Models.Data {

    /// <summary>
    /// Einzelner Cashflow
    /// </summary>
    public abstract record SingleCashFlow : LiquidityBase {

        /// <summary>
        /// Datum
        /// </summary>
        public DateTime Date {
            get;
            init;
        } = new DateTime(DateTime.Now.Year, 1, 1);

        /// <summary>
        /// Betrag
        /// </summary>
        public double Value {
            get;
            init;
        }

    }

}