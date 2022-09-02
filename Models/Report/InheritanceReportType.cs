namespace Gschwind.Lighthouse.Example.Models.Report;

/// <summary>
/// Arten von Nachfolgeauswertungen
/// </summary>
public enum InheritanceReportType {
    /// <summary>
    /// Gebäudewert nach Ablauf
    /// </summary>
    AssetExpirationValue,
    /// <summary>
    /// Durchschnittlicher Ertragswert
    /// </summary>
    AverageProfitValue,
    /// <summary>
    /// Erbbaurecht
    /// </summary>
    BuildingLeasehold,
    /// <summary>
    /// Bodenwert
    /// </summary>
    BuildingLeaseholdGround,
    /// <summary>
    /// Gebäudereinertrag
    /// </summary>
    BuildingNetIncome,
    /// <summary>
    /// Gebäudeherstellungskosten
    /// </summary>
    BuildingProductionCosts,
    /// <summary>
    /// Ziviler Erwerb
    /// </summary>
    CivilPurchase,
    /// <summary>
    /// Abzug vom Betriebsvermögen
    /// </summary>
    CompanyDeductionAmount,
    /// <summary>
    /// Ertragswert
    /// </summary>
    CompanyProfitValuation,
    /// <summary>
    /// Ertragswert 1
    /// </summary>
    CompanyProfitValue1,
    /// <summary>
    /// Ertragwert 2
    /// </summary>
    CompanyProfitValue2,
    /// <summary>
    /// Ertragwert 3
    /// </summary>
    CompanyProfitValue3,
    /// <summary>
    /// Summe der Ertragswerte
    /// </summary>
    CompanyProfitValueSum,
    /// <summary>
    /// Abschmelzung
    /// </summary>
    DecuctionExceed,
    /// <summary>
    /// Entlastungsbetrag
    /// </summary>
    DischargeAmount,
    /// <summary>
    /// Abgezinster Bodenwert
    /// </summary>
    DiscountedGroundValue,
    /// <summary>
    /// Abzinsfaktor
    /// </summary>
    DiscountFactor,
    /// <summary>
    /// Nachlass
    /// </summary>
    Estate,
    /// <summary>
    /// Anteil begünstigtes Vermögen
    /// </summary>
    FavourPurchaseQuote,
    /// <summary>
    /// Zugewinndifferenz
    /// </summary>
    GainDifference,
    /// <summary>
    /// Unterschiedsbetrag
    /// </summary>
    GroundInterestDifference,
    /// <summary>
    /// Erbbaugrundstück
    /// </summary>
    GroundLeasehold,
    /// <summary>
    /// Bodenwert
    /// </summary>
    GroundLeaseholdGround,
    /// <summary>
    /// Bodenwertverzinsung
    /// </summary>
    GroundValueInterest,
    /// <summary>
    /// Hausratsfreibetrag
    /// </summary>
    HouseholdAllowance,
    /// <summary>
    /// Zu versteuernder Erwerb
    /// </summary>
    InheritanceNetTaxable,
    /// <summary>
    /// Erbschaftsteuer
    /// </summary>
    InheritanceTax,
    /// <summary>
    /// Unterschiedsbetrag
    /// </summary>
    InheritanceTaxDifference,
    /// <summary>
    /// Gebäudewert
    /// </summary>
    LeaseholdBuilding,
    /// <summary>
    /// Obergrenze für Pflichtteilserhalt
    /// </summary>
    LegacyPortionReceipt,
    /// <summary>
    /// Vermächtnisquote
    /// </summary>
    LegacyQoute,
    /// <summary>
    /// Vermächtniskürzungen §2318
    /// </summary>
    LegacyReduction,
    /// <summary>
    /// Pflichtteil
    /// </summary>
    LegalPortion,
    /// <summary>
    /// Pflichtteilslast
    /// </summary>
    LegalPortionExpenses,
    /// <summary>
    /// Pflichtteilsforderungen
    /// </summary>
    LegalPortionIncome,
    /// <summary>
    /// Pflichtteilszahlungen
    /// </summary>
    LegalPortionPayments,
    /// <summary>
    /// Vervielfältiger
    /// </summary>
    Mulitplier,
    /// <summary>
    /// Ohne Entschädigung
    /// </summary>
    NotCompensated,
    /// <summary>
    /// Versorgungsfreibetrag
    /// </summary>
    PensionAllowance,
    /// <summary>
    /// Barwert Erbbauzins
    /// </summary>
    PresentGroundRent,
    /// <summary>
    /// Gebäudewert nach Ablauf
    /// </summary>
    ProfitExpirationValue,
    /// <summary>
    /// Sachwert Gebäude
    /// </summary>
    PropertyAsset,
    /// <summary>
    /// Bodenwert
    /// </summary>
    PropertyGround,
    /// <summary>
    /// Ertragswert Gebäude
    /// </summary>
    PropertyProfit,
    /// <summary>
    /// Pflichtteilszahlungen
    /// </summary>
    RemainingLegalPortion,
    /// <summary>
    /// Zugewinn Partner
    /// </summary>
    SpouseGain,
    /// <summary>
    /// Anfangsvermögen (indexiert)
    /// </summary>
    SpouseInitialAssetsIndexed,
    /// <summary>
    /// Geldwerte
    /// </summary>
    TaxableCash,
    /// <summary>
    /// Steuerwert / Verkehrswert
    /// </summary>
    TaxableCivilRate,
    /// <summary>
    /// Beteiligungen
    /// </summary>
    TaxableCompanies,
    /// <summary>
    /// Beteiligung (1 - n)
    /// </summary>
    TaxableCompanyItem,
    /// <summary>
    /// Bewertung
    /// </summary>
    TaxableCompanyValuation,
    /// <summary>
    /// Abzug nach ErbStG §10 (6)
    /// </summary>
    TaxableDiscount,
    /// <summary>
    /// Schulden und Lasten
    /// </summary>
    TaxableLiabilities,
    /// <summary>
    /// Immobilien
    /// </summary>
    TaxableProperties,
    /// <summary>
    /// Immobilie (1 - n)
    /// </summary>
    TaxablePropertyItem,
    /// <summary>
    /// Bewertung
    /// </summary>
    TaxablePropertyValuation,
    /// <summary>
    /// Steuerlicher Erwerb
    /// </summary>
    TaxablePurchase,
    /// <summary>
    /// Steuerfreier Zugewinn
    /// </summary>
    TaxlessGain,
    /// <summary>
    /// Zugewinn Kunde
    /// </summary>
    TestatorGain,
    /// <summary>
    ///  Anfangsvermögen (indexiert)
    /// </summary>
    TestatorInitialAssetsIndexed,
    /// <summary>
    /// Verträge zugunsten Dritter
    /// </summary>
    ThirdPartyContracts
}
