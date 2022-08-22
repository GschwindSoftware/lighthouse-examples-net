using Newtonsoft.Json;

namespace Gschwind.Lighthouse.Example.Models;

/// <summary>
/// Parameter einer Abfrage
/// </summary>
/// <seealso cref="QueryResult{T}"/>
public class Query {

    /// <summary>
    /// Optionale Zeichenfolge, mittels derer Elemente gesucht werden
    /// </summary>
    public string? Search {
        get;
        set;
    }

    /// <summary>
    /// Optionaler Filter zur Eingrenzung der Suchtreffer
    /// </summary>
    public Term? Filter {
        get;
        set;
    }

    /// <summary>
    /// Optionale Sortieroperationen
    /// </summary>
    public ICollection<OrderBy>? Ordering {
        get;
        set;
    }

    /// <summary>
    /// Optionale Namen der Eigenschaften, die in die Ergebnismenge übernommen werden
    /// </summary>
    public ICollection<string>? Include {
        get;
        set;
    }

    /// <summary>
    /// Optionale Namen der Eigenschaften, die nicht in die Ergebnismenge übernommen werden
    /// </summary>
    public ICollection<string>? Exclude {
        get;
        set;
    }

    /// <summary>
    /// Die Anzahl zu überspringender Suchtreffer
    /// </summary>
    /// <value>
    /// Wert größer oder gleich <c>0</c>
    /// </value>
    public int Skip {
        get;
        set;
    }

    /// <summary>
    /// Wenn gesetzt, wird höchstens diese Anzahl von Suchtreffern zurückgegeben
    /// </summary>
    /// <value>
    /// Wert größer oder gleich <c>0</c>, bzw. <see langword="null"/> für keine Begrenzung
    /// </value>
    [JsonProperty(NullValueHandling = NullValueHandling.Include)]
    public int? Take {
        get;
        set;
    }

}
