namespace Gschwind.Lighthouse.Example.Models.Data;

/// <summary>
/// Eine Wertpapierorder
/// </summary>
public record SecurityOrder {

    /// <summary>
    /// Order Datum
    /// </summary>
    public DateTime Date {
        get;
        init;
    }

    /// <summary>
    /// Stückzahl
    /// </summary>
    public double Quantity {
        get;
        init;
    } = 1;

    /// <summary>
    /// Kaufpreis
    /// </summary>
    public double Price {
        get;
        init;
    }

}
