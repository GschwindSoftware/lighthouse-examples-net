using System.Collections;
using Newtonsoft.Json;

namespace Gschwind.Lighthouse.Example.Models;

/// <summary>
/// Die Ergebnismenge mit den Suchtreffern einer <see cref="Query">Abfrage</see>
/// </summary>
/// <seealso cref="Query"/>
[JsonObject]
public record QueryResult<T> : IReadOnlyCollection<T> {

    [JsonProperty("matches")]
    IReadOnlyCollection<T> _matches = Array.Empty<T>();

    /// <summary>
    /// Die Anzahl der übersprungenen Suchtreffer
    /// </summary>
    /// <seealso cref="Query.Skip"/>
    public int Offset {
        get;
        init;
    }

    /// <summary>
    /// Die Gesamtanzahl aller möglichen Suchtreffer. Eine Abfrage kann eine Untermenge an Elementen zurückgeben
    /// </summary>
    /// <seealso cref="Query.Skip"/>
    /// <seealso cref="Query.Take"/>
    public int Total {
        get;
        init;
    }

    #region IReadOnlyCollection`1

    /// <summary>
    /// Die Anzahl der enthaltenen Suchtreffer
    /// </summary>
    /// <seealso cref="Query.Take"/>
    public int Count => _matches.Count;

    /// <inheritdoc/>
    public IEnumerator<T> GetEnumerator() => _matches.GetEnumerator();

    /// <inheritdoc/>
    IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

    #endregion

}
