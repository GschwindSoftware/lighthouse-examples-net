namespace Gschwind.Lighthouse.Example.Models.Data;

/// <summary>
/// Bankeinlage
/// </summary>
public abstract record Deposit : PlanData {

    /// <summary>
    /// Name des Instituts
    /// </summary>
    public string Institute {
        get;
        set;
    } = String.Empty;

    /// <summary>
    /// Kontonummer
    /// </summary>
    public string AccountNumber {
        get;
        set;
    } = String.Empty;

    /// <summary>
    /// Jährliche Gebühr in %
    /// </summary>
    public double AnnualFeeRate {
        get;
        set;
    }

    /// <summary>
    /// Maximale Jahresgebühr (EUR)
    /// </summary>
    public double AnnualFeeMaximum {
        get;
        set;
    }

    /// <summary>
    /// Sind die Gebühren steuerlich relevant?
    /// </summary>
    public bool IsFeeTaxable {
        get;
        set;
    }

    /// <summary>
    /// Steuerlich zu berücksichtigender Anteil der Gebühren in %
    /// </summary>
    public double TaxableFeeRate {
        get;
        set;
    } = 50;

}
