namespace Gschwind.Lighthouse.Example.Models.Data;

/// <summary>
/// Zahlung der Beiträge zu einer betrieblichen Altersvorsorge
/// </summary>
public enum PremiumPayment {
    /// <summary>
    /// Aus Gehaltsumwandlung
    /// </summary>
    Employee,
    /// <summary>
    /// Vom Arbeitgeber
    /// </summary>
    Employer = 1
}
