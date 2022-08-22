namespace Gschwind.Lighthouse.Example.Models;

/// <summary>
/// Term zur Filterung einer <see cref="Query">Abfrage</see>
/// </summary>
/// <seealso cref="Query"/>
public abstract record Term() {

    /// <summary>
    /// Verknüpft zwei Filterterme mit <see cref="LogicalOperator.Or"/>
    /// </summary>
    /// <param name="t1">Erster Filterterm</param>
    /// <param name="t2">Zweiter Filterterm</param>
    /// <returns>Resultierender Filterterm</returns>
    public static Term? operator |(Term? t1, Term? t2) =>
        Join(t1, t2, LogicalOperator.Or);

    /// <summary>
    /// Verknüpft zwei Filterterme mit <see cref="LogicalOperator.And"/>
    /// </summary>
    /// <param name="t1">Erster Filterterm</param>
    /// <param name="t2">Zweiter Filterterm</param>
    /// <returns>Resultierender Filterterm</returns>
    public static Term? operator &(Term? t1, Term? t2) =>
        Join(t1, t2, LogicalOperator.And);

    static Term? Join(Term? t1, Term? t2, LogicalOperator op) {
        if (t1 == null)
            return t2;
        else if (t2 == null)
            return t1;

        Conjunction fromTerms(IEnumerable<Term> terms, LogicalOperator op) {
            var c = new Conjunction(op);
            foreach (var term in terms)
                c.Add(term);
            return c;
        }

        if (t1 is Conjunction c1 && c1.Operator == op) {
            if (t2 is Conjunction c2 && c2.Operator == op)
                return fromTerms(c1.Concat(c2), op);
            return fromTerms(c1.Concat(new[] { t2 }), op);
        } else if (t2 is Conjunction c2 && c2.Operator == op)
            return fromTerms(new[] { t1 }.Concat(c2), op);

        return new Conjunction(op) { t1, t2 };
    }

}
