using System;

namespace Gschwind.Lighthouse.Example.Models.Data {

    /// <summary>
    /// Pensionszusage
    /// </summary>
    public record PensionCommitment : CompanyPensionOther {

        /// <summary>
        /// Ist die Rente befristet
        /// </summary>
        public bool IsPensionLimitated {
            get;
            init;
        }

        /// <summary>
        /// Datum der Rentenbefristung
        /// </summary>
        public DateTime PensionLimitation {
            get;
            init;
        } = new DateTime(2027, 12, 31);

    }

}
