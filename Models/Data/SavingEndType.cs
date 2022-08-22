namespace Gschwind.Lighthouse.Example.Models.Data;

/// <summary>
/// Sparende
/// </summary>
public enum SavingEndType {
    /// <summary>
    /// An einem bestimmten Datum
    /// </summary>
    AtDate,
    /// <summary>
    /// Endet nie
    /// </summary>
    EndsNever = 1,
    /// <summary>
    /// Bei Erreichen des Mindestguthabens
    /// </summary>
    AtMinimumBalance = 4
}
