using System.Collections;
using Newtonsoft.Json;

namespace Gschwind.Lighthouse.Example.Models;

/// <summary>
/// Ein <see cref="Term"/>, der mehrere Terme logisch verknüpft
/// </summary>
/// <param name="Operator">Der Verknüpfungsoperator</param>
[JsonObject]
public record Conjunction([property: JsonProperty("op")]LogicalOperator Operator) : Term(), ICollection<Term> {

    [JsonProperty(PropertyName = "terms")]
    readonly List<Term> _terms = new();

    #region ICollection`1

    /// <inheritdoc/>
    int ICollection<Term>.Count => _terms.Count;

    /// <inheritdoc/>
    bool ICollection<Term>.IsReadOnly => false;

    /// <inheritdoc/>
    public void Add(Term item) => _terms.Add(item);

    /// <inheritdoc/>
    public bool Remove(Term item) => _terms.Remove(item);

    /// <inheritdoc/>
    public void Clear() => _terms.Clear();

    /// <inheritdoc/>
    public bool Contains(Term item) => _terms.Contains(item);

    /// <inheritdoc/>
    void ICollection<Term>.CopyTo(Term[] array, int arrayIndex) => _terms.CopyTo(array, arrayIndex);

    /// <inheritdoc/>
    IEnumerator<Term> IEnumerable<Term>.GetEnumerator() => _terms.GetEnumerator();

    /// <inheritdoc/>
    IEnumerator IEnumerable.GetEnumerator() => ((IEnumerable<Term>)this).GetEnumerator();

    #endregion

}
