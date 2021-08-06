using System;

namespace Gschwind.Lighthouse.Example.Models.Data {

    /// <summary>
    /// Minijob
    /// </summary>
    public record MiniJob : IncomeBase {

        /// <summary>
        /// Rentenversicherungspflichtig
        /// </summary>
        public bool PensionInsuranceDuty {
            get;
            init;
        } = true;

        /// <summary>
        /// Einkunftstyp
        /// </summary>
        public MiniJobEmployer IncomeType {
            get;
            init;
        } = MiniJobEmployer.Operational;

        /// <summary>
        /// Erzeugt eine neue Instanz der <see cref="MiniJob"/>-Klasse
        /// </summary>
        public MiniJob() {
            CashFlows = CashFlows with { Period = Period.Monthly };
            Termination = Termination with { Type  = MomentType.AtRetirement };
        }

    }

}