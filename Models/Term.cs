using System.Linq.Expressions;

namespace Gschwind.Lighthouse.Example.Models;

/// <summary>
/// Term zur Filterung einer <see cref="Query">Abfrage</see>
/// </summary>
/// <seealso cref="Query"/>
public abstract record Term() {

    /// <summary>
    /// Erzeugt ein <see cref="Predicate"/>-Term der auf Gleichheit prüft
    /// </summary>
    /// <param name="memberAccessor">Die Eigenschaft <see cref="Predicate.Property">Eigensachaft</see>, die verglichen wird</param>
    /// <param name="value">Der Wert, mit dem verglichen werden soll</param>
    /// <typeparam name="T">Der Typ des Objekts, auf dem verglichen wird</typeparam>
    /// <returns>Das erzeugte <see cref="Predicate"/></returns>
    public static Term Eq<T>(Expression<Func<T, object?>> memberAccessor, object? value) =>
        Predicate<T>(memberAccessor, RelationalOperator.Equals, value);

    /// <summary>
    /// Erzeugt ein <see cref="Predicate"/>-Term der auf Ungleichheit prüft
    /// </summary>
    /// <param name="memberAccessor">Die Eigenschaft <see cref="Predicate.Property">Eigensachaft</see>, die verglichen wird</param>
    /// <param name="value">Der Wert, mit dem verglichen werden soll</param>
    /// <typeparam name="T">Der Typ des Objekts, auf dem verglichen wird</typeparam>
    /// <returns>Das erzeugte <see cref="Predicate"/></returns>
    public static Term Ne<T>(Expression<Func<T, object?>> memberAccessor, object? value) =>
        Predicate<T>(memberAccessor, RelationalOperator.NotEquals, value);

    static Term Predicate<T>(Expression<Func<T, object?>> memberAccessor, RelationalOperator op, object? value) {
        var properties = memberAccessor.GetPropertyAccessList();
        var path = String.Join('.', properties.Select(p => p.Name));
        return new Predicate(path, op, value);
    }

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
