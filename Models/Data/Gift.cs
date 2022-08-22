namespace Gschwind.Lighthouse.Example.Models.Data {

    /// <summary>
    /// Schenkung
    /// </summary>
    public record Gift : SingleCashFlow {

        /// <summary>
        /// Liquiditätswirksam
        /// </summary>
        public bool IsLiquidityRelevant {
            get;
            init;
        } = true;

        /// <summary>
        /// Beschenkter
        /// </summary>
        public Guid Donee {
            get;
            init;
        } = Guid.Empty;

        /// <summary>
        /// Steuerwert
        /// </summary>
        public double TaxValue {
            get;
            init;
        }

        /// <summary>
        /// Bezahlte Schenkungssteuer
        /// </summary>
        public double PaidGiftTax {
            get;
            init;
        }

        /// <summary>
        /// Indexierung des Wertes
        /// </summary>
        public bool Indexation {
            get;
            init;
        } = true;

        /// <summary>
        /// Anrechnung auf den Pflichtteil
        /// </summary>
        public bool ChargeLegalPortion {
            get;
            init;
        }

    }

}
