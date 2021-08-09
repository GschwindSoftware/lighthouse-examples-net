using System;

namespace Gschwind.Lighthouse.Example.Models.Plans.Settings {

    /// <summary>
    /// Der Begünstigte
    /// </summary>
    public record Beneficiary {

        /// <summary>
        /// ID der Person
        /// </summary>
        public Guid PersonId {
            get;
            init;
        } = Guid.Empty;

        /// <summary>
        /// Name der begünstigten Person
        /// </summary>
        public string PersonName {
            get;
            init;
        } = String.Empty;

    }

}
