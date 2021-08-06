
namespace Gschwind.Lighthouse.Example.Models.Data {

    /// <summary>
    /// Berufsunfähigkeitsversicherung
    /// </summary>
    public record DisabilityInsurance : PersonalInsurance {

        /// <summary>
        /// Rente
        /// </summary>
        public CashFlows Pension {
            get;
            init;
        } = new CashFlows { Period = Period.Monthly };

        /// <summary>
        /// Rentenende
        /// </summary>
        public Moment PensionEnd {
            get;
            init;
        } = new Moment { Type = MomentType.AtRetirement };


        /// <summary>
        /// Leistungsbeginn verschiebt sich um x Wochen
        /// </summary>
        public int WeeksAfterDetermination {
            get;
            init;
        } = 0;

    }

}
