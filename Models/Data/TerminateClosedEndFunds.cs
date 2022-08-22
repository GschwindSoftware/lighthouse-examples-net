namespace Gschwind.Lighthouse.Example.Models.Data {

    /// <summary>
    /// Geschlossenen Fonds verkaufen
    /// </summary>
    public record TerminateClosedEndFunds : Termination {

        /// <summary>
        /// Besteuerung
        /// </summary>
        public Taxation SaleTaxation {
            get;
            init;
        } = Taxation.IncomeTax;

        /// <summary>
        /// Steuerpflichtig in %
        /// </summary>
        public double Taxable {
            get;
            init;
        } = 100.0;

    }

}
