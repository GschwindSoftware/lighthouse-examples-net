using System;

namespace Gschwind.Lighthouse.Example.Models.Data {

    /// <summary>
    /// Darlehen beenden
    /// </summary>
    public record TerminateLoan : Termination {

        /// <summary>
        /// Vorfälligkeitsentschädigung
        /// </summary>
        public double PrepaymentPenalty {
            get;
            init;
        } = 0.0;

    }

}
