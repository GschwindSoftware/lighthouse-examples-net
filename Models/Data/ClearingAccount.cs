using System;

namespace Gschwind.Lighthouse.Example.Models.Data {

    /// <summary>
    /// Verrechnungskonto
    /// </summary>
    public record ClearingAccount : CashValue {

        /// <summary>
        /// Sollzinssatz
        /// </summary>
        public double DebitRate {
            get;
            init;
        } = 0.0;

        /// <summary>
        /// Erzeugt eine neue Instanz der <see cref="ClearingAccount"/>-Klasse
        /// </summary>
        public ClearingAccount() =>
            Name = "Liquiditätsüberschuss";

    }

}
