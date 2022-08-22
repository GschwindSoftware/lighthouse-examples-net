namespace Gschwind.Lighthouse.Example.Models.Data {

    /// <summary>
    /// Beschreibt einen Zeitpunkt
    /// </summary>
    public record Moment {

        /// <summary>
        /// Art des Zeitpunktes
        /// </summary>
        public MomentType Type {
            get;
            init;
        } = MomentType.Never;

        /// <summary>
        /// Datum des Zeitpunktes (bei <see cref="MomentType.AtDate"/>)
        /// </summary>
        public DateTime Date {
            get;
            init;
        } = new(DateTime.Now.Year + 10, 1, 1);

        /// <summary>
        /// Alter des Eigentümers (bei <see cref="MomentType.AtAge"/>)
        /// </summary>
        public int Age {
            get;
            init;
        } = 65;

        /// <summary>
        /// Erzeugt ein <see cref="Moment"/>-Objekt mit <see cref="MomentType.AtDate"/>
        /// </summary>
        /// <param name="date">Datum des Zeitpunktes</param>
        /// <returns>Das erzeugte <see cref="Moment"/>-Objekt</returns>
        public static Moment AtDate(DateTime date) => new() {
            Type = MomentType.AtDate,
            Date = date
        };

        /// <summary>
        /// Erzeugt ein <see cref="Moment"/>-Objekt mit <see cref="MomentType.AtAge"/>
        /// </summary>
        /// <param name="age">Alter des Eigentümers</param>
        /// <returns>Das erzeugte <see cref="Moment"/>-Objekt</returns>
        public static Moment AtAge(int age) => new() {
            Type = MomentType.AtAge,
            Age = age
        };

    }

}
