namespace Gschwind.Lighthouse.Example.Models.Data;

/// <summary>
/// Verwandschaftgrad
/// </summary>
public enum RelativeType {
    /// <summary>
    /// Sonstige Person
    /// </summary>
    Other,
    /// <summary>
    /// Ehegatte
    /// </summary>
    Spouse,
    /// <summary>
    /// Lebenspartner
    /// </summary>
    LifePartner,
    /// <summary>
    /// Kind
    /// </summary>
    Child,
    /// <summary>
    /// Enkelkind
    /// </summary>
    GrandChild,
    /// <summary>
    /// Urenkel
    /// </summary>
    GreatGrandChild,
    /// <summary>
    /// Stiefkind
    /// </summary>
    StepChild,
    /// <summary>
    /// Eltern
    /// </summary>
    Parent,
    /// <summary>
    /// Großeltern
    /// </summary>
    GrandParent,
    /// <summary>
    /// Geschwister
    /// </summary>
    Sibling,
    /// <summary>
    /// Neffe
    /// </summary>
    Nephew,
    /// <summary>
    /// Geschiedener Ehegatte
    /// </summary>
    DivorcedSpouse,
    /// <summary>
    /// Stiefenkel
    /// </summary>
    StepGrandChild,
    /// <summary>
    /// Tante oder Onkel
    /// </summary>
    AuntUncel,
    /// <summary>
    /// Schwiegerkind
    /// </summary>
    ChildInLaw,
    /// <summary>
    /// Großneffe
    /// </summary>
    GrandNephew
}
