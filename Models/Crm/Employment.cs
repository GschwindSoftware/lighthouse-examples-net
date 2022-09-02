namespace Gschwind.Lighthouse.Example.Models.Crm;

/// <summary>
/// Ein Beschäftigungsverhältnis in einem Unrternehmen
/// </summary>
/// <param name="Id">Der eindeutige Schlüssel des Beschäftigungsverhältnis</param>
/// <param name="Position">Die Position des Beschäftigten</param>
/// <param name="Department">Der Unternehmensbereich oder die Abteilung, in der der Beschäftigte arbeitet</param>
/// <param name="IsDeparted">Wert, der angibt, ob der Bechäftigte aus dem Unternehmen ausgeschieden ist</param>
/// <param name="Person">Der Schlüssel der beschäftigten Person</param>
/// <param name="Company">Der Schlüssel des Unternehmens, dem der Beschäftigte angehört</param>
public record Employment(
    int Id,
    string? Position,
    string? Department,
    bool IsDeparted,
    Guid Person,
    Guid Company
);
