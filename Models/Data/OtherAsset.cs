namespace Gschwind.Lighthouse.Example.Models.Data;

/// <summary>
/// Sonstiges Vermögen
/// </summary>
public record OtherAsset : RealValue {

    /// <summary>
    /// Einkunftsart für den Verkauf
    /// </summary>
    public IncomeType IncomeType {
        get;
        init;
    } = IncomeType.Other;

}
