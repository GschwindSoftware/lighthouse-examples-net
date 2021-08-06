
namespace Gschwind.Lighthouse.Example.Models.Data {

    /// <summary>
    /// Berufsausbildung
    /// </summary>
    public record VocationalTraining : ExpenseBase {

        /// <summary>
        /// Besteuerung
        /// </summary>
        public VocationalTrainingTaxation VocationalTrainingTaxation {
            get;
            init;
        } = VocationalTrainingTaxation.InitialEducation;

    }

}