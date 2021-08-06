using System;

namespace Gschwind.Lighthouse.Example.Models.Data {

    /// <summary>
    /// Sonstige betriebliche Altersvorsorge
    /// </summary>
    public abstract record CompanyPensionOther : CompanyPension {

        /// <summary>
        /// Kapitalleistung wird nach Fünftelregelung besteuert
        /// </summary>
        public bool IsFifthPartRule {
            get;
            init;
        }

    }

}