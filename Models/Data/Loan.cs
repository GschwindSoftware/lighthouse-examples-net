namespace Gschwind.Lighthouse.Example.Models.Data;

/// <summary>
/// Endfälliges Darlehen
/// </summary>
public record Loan : LiabilityBase {

    /// <summary>
    /// Darlehensnominalbetrag
    /// </summary>
    public double LoanAmount {
        get;
        init;
    }

    /// <summary>
    /// Restschuld
    /// </summary>
    public DateValue RemainingDebt {
        get;
        init;
    } = new();

    /// <summary>
    /// Nominalbetrag oder Restschuld
    /// </summary>
    public LoanAmountType AmountType {
        get;
        init;
    } = LoanAmountType.Amount;

    /// <summary>
    /// Name des Instituts
    /// </summary>
    public string Institute {
        get;
        init;
    } = String.Empty;

    /// <summary>
    /// Kontonummer
    /// </summary>
    public string AccountNumber {
        get;
        init;
    } = String.Empty;

    /// <summary>
    /// Darlehenstyp
    /// </summary>
    public LoanType LoanType {
        get;
        init;
    } = LoanType.Annuity;

    /// <summary>
    /// Start der Tilgung bei Darlehensbeginn
    /// </summary>
    public bool IsPaymentAutomated {
        get;
        init;
    } = true;

    /// <summary>
    /// Disagio
    /// </summary>
    public double Disagio {
        get;
        init;
    }

    /// <summary>
    /// Annuität in EUR bei Annuitätendarlehen / Tilgung in EUR bei Tilgungsdarlehen
    /// </summary>
    public ICollection<DateValue> Repayments {
        get;
        init;
    } = [];

    /// <summary>
    /// Tilgungsintervall
    /// </summary>
    public Period RepaymentInterval {
        get;
        init;
    } = Period.Monthly;

    /// <summary>
    /// Sondertilgungen
    /// </summary>
    public ICollection<DateValue> AdditionalRepayments {
        get;
        init;
    } = [];

    /// <summary>
    /// Zinssätze in %
    /// </summary>
    public ICollection<PercentValue> InterestRates {
        get;
        init;
    } = [];

    /// <summary>
    /// Ende der Zinsbindung
    /// </summary>
    public DateTime? EndOfFixedInterestRate {
        get;
        init;
    }

    /// <summary>
    /// Zinszuschüsse
    /// </summary>
    public ICollection<DateValue> InterestGrants {
        get;
        init;
    } = [];

    /// <summary>
    /// Teilauszahlungen der Darlehenssumme
    /// </summary>
    public ICollection<DateValue> LoanPayouts {
        get;
        init;
    } = [];

    /// <summary>
    /// Auszahlung zu Darlehensbeginn
    /// </summary>
    public bool PayoutAtLoanStart {
        get;
        init;
    } = true;

    /// <summary>
    /// Steuerlich relevant
    /// </summary>
    public bool IsTaxable {
        get;
        init;
    } = true;

    /// <summary>
    /// Steuerliche relevanter Prozentsatz der Zinszahlungen
    /// </summary>
    public double TaxRelevantRate {
        get;
        init;
    } = 100;

    /// <summary>
    /// Steuerliche Einkunftsart
    /// </summary>
    public TaxableLoanType TaxType {
        get;
        init;
    } = TaxableLoanType.Automatic;

    /// <summary>
    /// Bereitstellungszins in %
    /// </summary>
    public double CommitmentInterestRate {
        get;
        init;
    }

    /// <summary>
    /// Anzahl bereitsellungsfreie Monate
    /// </summary>
    public int FreeCommitmentMonths {
        get;
        init;
    } = 6;

    /// <summary>
    /// Bezug
    /// </summary>
    public Guid Reference {
        get;
        init;
    } = Guid.Empty;

}
