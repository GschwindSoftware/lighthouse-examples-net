
namespace Gschwind.Lighthouse.Example.Models.Data {

    /// <summary>
    /// Mitgliedsbeitrag
    /// </summary>
    public record MembershipFee : ExpenseBase {

        /// <summary>
        /// Steuerliche Begünstigung
        /// </summary>
        public MembershipTaxAdvantage MembershipTaxAdvantage {
            get;
            init;
        } = MembershipTaxAdvantage.None;

    }

}