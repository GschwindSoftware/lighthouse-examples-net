
namespace Gschwind.Lighthouse.Example.Models.Data {

    /// <summary>
    /// Unterhaltszahlung
    /// </summary>
    public record Alimony : ExpenseBase {

        /// <summary>
        /// Art der Unterhaltszahlung
        /// </summary>
        public AlimonyTaxType AlimonyTaxType {
            get;
            init;
        } = AlimonyTaxType.ExceptionalCosts;

    }

}
