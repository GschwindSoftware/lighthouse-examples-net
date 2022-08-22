using System.Data.SqlClient;

namespace Gschwind.Lighthouse.Example.Models;

/// <summary>
/// Sortieroperation einer <see cref="Query">Abfrage</see>
/// </summary>
/// <param name="Property">Name der Eigenschaft, nach der sortiert werden soll</param>
/// <param name="Order">Die Sortierungsrichtung</param>
/// <seealso cref="Query"/>
public record OrderBy(string Property, SortOrder Order = SortOrder.Ascending);
