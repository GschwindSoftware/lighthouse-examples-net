using System;

namespace Gschwind.Lighthouse.Example.Models.Data {

    /// <summary>
    /// Basis für alle Vorgänge
    /// </summary>
    public abstract record PlanData {

        /// <summary>
        /// Die eindeutige Id des Vorgangs
        /// </summary>
        public Guid Id {
            get;
            init;
        } = Guid.NewGuid();

        /// <summary>
        /// Die eindeutige Guid des Vorgangs
        /// </summary>
        public string ImportId {
            get;
            init;
        } = String.Empty;

        /// <summary>
        /// Vorgangsname
        /// </summary>
        public string Name {
            get;
            init;
        } = String.Empty;

        /// <summary>
        /// Währung
        /// </summary>
        public Currency Currency {
            get;
            init;
        } = Currency.EUR;

    }

}
