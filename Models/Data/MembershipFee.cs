namespace Gschwind.Lighthouse.Example.Models.Data {

    /// <summary>
    /// Mitgliedsbeitrag
    /// </summary>
    public record MembershipFee : CashFlowBase {

        /// <summary>
        /// Steuerliche Begünstigung
        /// </summary>
        public MembershipTaxAdvantage MembershipTaxAdvantage {
            get;
            init;
        } = MembershipTaxAdvantage.None;

    }

}
