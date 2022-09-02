namespace Gschwind.Lighthouse.Example.Models.Data;

/// <summary>
/// Arztpraxis
/// </summary>
public record MedicalPractice : Partnership {

    /// <summary>
    /// Regelleistungen
    /// </summary>
    public ICollection<StandardBenefit> StandardBenefits {
        get;
        init;
    } = new List<StandardBenefit>();

}
