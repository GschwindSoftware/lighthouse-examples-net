namespace Gschwind.Lighthouse.Example.Models.Data {

    /// <summary>
    /// Risiko-Szenario
    /// </summary>
    public record ScenarioParameter {

        /// <summary>
        /// Veränderung Normalfall in %
        /// </summary>
        public double NormalCase {
            get;
            init;
        } = 100;

        /// <summary>
        /// Veränderung Krankheit in %
        /// </summary>
        public double Illness {
            get;
            init;
        }

        /// <summary>
        /// Veränderung Pflegefall in %
        /// </summary>
        public double NursingCase {
            get;
            init;
        }

        /// <summary>
        /// Veränderung Erwerbsunfähigkeit in %
        /// </summary>
        public double Disability {
            get;
            init;
        }

        /// <summary>
        /// Veränderung Tod in %
        /// </summary>
        public double Death {
            get;
            init;
        }

    }

}
