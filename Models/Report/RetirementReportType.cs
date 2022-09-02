namespace Gschwind.Lighthouse.Example.Models.Report;

/// <summary>
/// Arten von Ruhestandsauswertungen
/// </summary>
public enum RetirementReportType {
    /// <summary>
    /// Weiteres Vermögen
    /// </summary>
    AdditionalAssets,
    /// <summary>
    /// Werbungskosten
    /// </summary>
    AgricultureAdvertisingCosts,
    /// <summary>
    /// Land- und Forstwirtschaft
    /// </summary>
    AgricultureIncome,
    /// <summary>
    /// Unterhaltszahlungen
    /// </summary>
    Alimonies,
    /// <summary>
    /// Gezahlter Unterhalt
    /// </summary>
    AlimoniesPayed,
    /// <summary>
    /// Rentenversicherungsbeiträge
    /// </summary>
    AllowablePensionContributions,
    /// <summary>
    /// Vermögensbildung
    /// </summary>
    AssetFormation,
    /// <summary>
    /// Vermögen
    /// </summary>
    Assets,
    /// <summary>
    /// Nettovermögen
    /// </summary>
    Balance,
    /// <summary>
    /// Basisbeiträge
    /// </summary>
    BasicContribution,
    /// <summary>
    /// Beiträge
    /// </summary>
    BavFlatRatePremium,
    /// <summary>
    /// Betriebliche Altersvorsorge
    /// </summary>
    BavFlatRateTaxation,
    /// <summary>
    /// Werbungskosten
    /// </summary>
    BusinessAdvertisingCosts,
    /// <summary>
    /// Gewerbebetriebe
    /// </summary>
    BusinessIncome,
    /// <summary>
    /// Werbungskosten
    /// </summary>
    CapitalAdvertisingCosts,
    /// <summary>
    /// Kapitalvermögen
    /// </summary>
    CapitalIncome,
    /// <summary>
    /// Kapitalleistung
    /// </summary>
    CapitalPayment,
    /// <summary>
    /// Fahrzeuge, Edelmetall und Kunst
    /// </summary>
    CarMetalArt,
    /// <summary>
    /// Geldwerte
    /// </summary>
    Cash,
    /// <summary>
    /// Liquide Verbindlichkeiten
    /// </summary>
    CashLiabilities,
    /// <summary>
    /// Kinderfreibetrag
    /// </summary>
    ChildAllowance,
    /// <summary>
    /// Kind (1 - n)
    /// </summary>
    ChildCareItem,
    /// <summary>
    /// Kinderbetreuungskosten
    /// </summary>
    ChildCares,
    /// <summary>
    /// Bemessungsgrundlage
    /// </summary>
    ChurchIncome,
    /// <summary>
    /// Einkommensteuer
    /// </summary>
    ChurchIncomeTax,
    /// <summary>
    /// Kirchensteuer
    /// </summary>
    ChurchTax,
    /// <summary>
    /// Kinderfreibetrag
    /// </summary>
    ChurchTaxChildAllowance,
    /// <summary>
    /// Geschlossene Fonds
    /// </summary>
    ClosedFunds,
    /// <summary>
    /// Unternehmensbeteiligungen
    /// </summary>
    Companies,
    /// <summary>
    /// Geschäftskonto
    /// </summary>
    CompanyAccount,
    /// <summary>
    /// Betriebsausgaben
    /// </summary>
    CompanyExpenses,
    /// <summary>
    /// Betriebseinnahmen
    /// </summary>
    CompanyIncome,
    /// <summary>
    /// Betriebliche Altersvorsorge
    /// </summary>
    CompanyInsurences,
    /// <summary>
    /// Zinsen
    /// </summary>
    CompanyInterest,
    /// <summary>
    /// Investitionen
    /// </summary>
    CompanyInvestments,
    /// <summary>
    /// Personengesellschaft (1 - n)
    /// </summary>
    CompanyLiquidityItem,
    /// <summary>
    /// Darlehensaufnahmen
    /// </summary>
    CompanyLoanIncome,
    /// <summary>
    /// Gewinnausschüttung
    /// </summary>
    CompanyPayouts,
    /// <summary>
    /// Betriebliche Altersvorsorge
    /// </summary>
    CompanyPension,
    /// <summary>
    /// Beiträge zur bAV
    /// </summary>
    CompanyPensionContributions,
    /// <summary>
    /// Gezahlte Beiträge
    /// </summary>
    CompanyPensionPayed,
    /// <summary>
    /// Beiträge zur bAV
    /// </summary>
    CompanyPensionPremiums,
    /// <summary>
    /// Betriebliche Altersvorsorge
    /// </summary>
    CompanyPensionScheme,
    /// <summary>
    /// Abschreibungen
    /// </summary>
    CompanyProfitAmortizations,
    /// <summary>
    /// Ausgaben
    /// </summary>
    CompanyProfitExpenses,
    /// <summary>
    /// Einnahmen
    /// </summary>
    CompanyProfitIncome,
    /// <summary>
    /// Zinsen
    /// </summary>
    CompanyProfitInterests,
    /// <summary>
    /// Personengesellschaft (1 - n)
    /// </summary>
    CompanyProfitItem,
    /// <summary>
    /// Tilgung
    /// </summary>
    CompanyRepayments,
    /// <summary>
    /// Steuermessbetrag
    /// </summary>
    CompanyTradeTaxBase,
    /// <summary>
    /// Gewerbesteuer
    /// </summary>
    CompanyTradeTaxItem,
    /// <summary>
    /// Ausgaben
    /// </summary>
    CoverExpenses,
    /// <summary>
    /// Liquidität mit Einzahlungen
    /// </summary>
    CoverGap,
    /// <summary>
    /// Einnahmen
    /// </summary>
    CoverIncome,
    /// <summary>
    /// Zinssatz
    /// </summary>
    CoverInterestRate,
    /// <summary>
    /// Zinsen
    /// </summary>
    CoverInterests,
    /// <summary>
    /// Überschuss / Unterdeckung
    /// </summary>
    CoverLiquidity,
    /// <summary>
    /// Anzahl Zahlungen
    /// </summary>
    CoverNumberOfPayments,
    /// <summary>
    /// Vorjahreswert
    /// </summary>
    CoverSaved,
    /// <summary>
    /// Einzahlungen
    /// </summary>
    CoverSavings,
    /// <summary>
    /// Liquidität
    /// </summary>
    CumulatedRetirementLiquidity,
    /// <summary>
    /// Sichteinlagen
    /// </summary>
    DemandDeposits,
    /// <summary>
    /// Spenden
    /// </summary>
    Donations,
    /// <summary>
    /// Summe der Einkünfte
    /// </summary>
    DonationsIncome,
    /// <summary>
    /// Maximal anrechenbar
    /// </summary>
    DonationsMaximum,
    /// <summary>
    /// Gezahlte Spenden
    /// </summary>
    DonationsPayed,
    /// <summary>
    /// Werbungskosten
    /// </summary>
    EmployedAdvertisingCosts,
    /// <summary>
    /// Nichtselbständige Tätigkeit
    /// </summary>
    EmployedIncome,
    /// <summary>
    /// Arbeitgeberanteile
    /// </summary>
    EmployersContributions,
    /// <summary>
    /// Übersteigende Beiträge (§ 40 b EStG)
    /// </summary>
    ExceedCompanyPensionPremiums,
    /// <summary>
    /// Außergewöhnliche Belastungen
    /// </summary>
    ExceptionalCosts,
    /// <summary>
    /// Gezahlte außergewöhnliche Belastungen
    /// </summary>
    ExceptionalCostsPayed,
    /// <summary>
    /// Zumutbare außergewöhnliche Belastungen
    /// </summary>
    ExceptionalCostsReasonable,
    /// <summary>
    /// Zumutbare Belastung Stufe 1
    /// </summary>
    ExceptionalCostsReasonableLevel1,
    /// <summary>
    /// Zumutbare Belastung Stufe 2
    /// </summary>
    ExceptionalCostsReasonableLevel2,
    /// <summary>
    /// Zumutbare Belastung Stufe 3
    /// </summary>
    ExceptionalCostsReasonableLevel3,
    /// <summary>
    /// Außerordentliche Steuern
    /// </summary>
    ExceptionalTax,
    /// <summary>
    /// Ausgaben
    /// </summary>
    Expenses,
    /// <summary>
    /// Gewerbebetrieb
    /// </summary>
    FifthPartBusiness,
    /// <summary>
    /// Einkünfte
    /// </summary>
    FifthPartBusinessIncome,
    /// <summary>
    /// Nichtselbständige Arbeit
    /// </summary>
    FifthPartEmployed,
    /// <summary>
    /// Einkünfte
    /// </summary>
    FifthPartEmployedIncome,
    /// <summary>
    /// Einkünfte
    /// </summary>
    FifthPartIncome,
    /// <summary>
    /// Sonstige Einkünfte
    /// </summary>
    FifthPartOther,
    /// <summary>
    /// Einkünfte
    /// </summary>
    FifthPartOtherIncome,
    /// <summary>
    /// Fünftelregelung
    /// </summary>
    FifthPartTax,
    /// <summary>
    /// Pauschalbesteuerung
    /// </summary>
    FlatRateTaxation,
    /// <summary>
    /// Auslandsimmobilien
    /// </summary>
    ForeignProperties,
    /// <summary>
    /// Geschlossene Fonds
    /// </summary>
    FundsProperties,
    /// <summary>
    /// Weitere Sonderausgaben
    /// </summary>
    FurtherExpenses,
    /// <summary>
    /// Einkünfte
    /// </summary>
    HalfAverageIncome,
    /// <summary>
    /// Halber Durschnittsteuerstz
    /// </summary>
    HalfAverageTax,
    /// <summary>
    /// Land- und Forstwirtschaft
    /// </summary>
    HealthAgricultureIncome,
    /// <summary>
    /// Bemessungsgrundlage
    /// </summary>
    HealthAssessment,
    /// <summary>
    /// Bemessungsgrundlage
    /// </summary>
    HealthAssessmentReduced,
    /// <summary>
    /// Gewerbebetrieb
    /// </summary>
    HealthBusinessIncome,
    /// <summary>
    /// Kapitalerträge
    /// </summary>
    HealthCapitalIncome,
    /// <summary>
    /// Einnahmen
    /// </summary>
    HealthIncomeReduced,
    /// <summary>
    /// Gesetzliche Krankenversicherung
    /// </summary>
    HealthInsurance,
    /// <summary>
    /// Gesetzliche Krankenversicherung
    /// </summary>
    HealthInsuranceBasic,
    /// <summary>
    /// Allgemeiner Beitrag
    /// </summary>
    HealthInsuranceGeneral,
    /// <summary>
    /// Beitragssatz
    /// </summary>
    HealthInsuranceRate,
    /// <summary>
    /// Beitragssatz
    /// </summary>
    HealthInsuranceRateReduced,
    /// <summary>
    /// Ermäßigter Beitrag
    /// </summary>
    HealthInsuranceReduced,
    /// <summary>
    /// Arbeitgeberanteil
    /// </summary>
    HealthInsuranceRefund,
    /// <summary>
    /// Bemessungsgrundlage
    /// </summary>
    HealthInsuranceRefundBase,
    /// <summary>
    /// Vermietung und Verpachtung
    /// </summary>
    HealthLettingAndLeasingIncome,
    /// <summary>
    /// Maximalbetrag
    /// </summary>
    HealthMaximumReduced,
    /// <summary>
    /// Sonstige Einkünfte
    /// </summary>
    HealthOtherIncome,
    /// <summary>
    /// Selbständige Arbeit
    /// </summary>
    HealthSelfEmployedIncome,
    /// <summary>
    /// Sozialversicherungspflichtig
    /// </summary>
    HealthSocialSecurityContributions,
    /// <summary>
    /// Einkommen
    /// </summary>
    HealthSocialSecurityIncome,
    /// <summary>
    /// Haushaltsnahe Handwerkerleistungen
    /// </summary>
    HouseholdCraftsmen,
    /// <summary>
    /// Arbeitslohn
    /// </summary>
    HouseholdCraftsmenExpenses,
    /// <summary>
    /// Haushaltsnahe Beschäftigungen
    /// </summary>
    HouseholdEmployment,
    /// <summary>
    /// Gezahlte Löhne
    /// </summary>
    HouseholdEmploymentExpenses,
    /// <summary>
    /// Hausrat
    /// </summary>
    HouseholdGoods,
    /// <summary>
    /// Haushaltsnahe Dienstleistungen
    /// </summary>
    HouseholdServices,
    /// <summary>
    /// Gezahlte Dienstleistungen
    /// </summary>
    HouseholdServicesExpenses,
    /// <summary>
    /// Einkommensteuer
    /// </summary>
    IncomeTax,
    /// <summary>
    /// Erbschaftsteuer
    /// </summary>
    InheritanceTaxes,
    /// <summary>
    /// Versicherungen
    /// </summary>
    InsuranceExpenses,
    /// <summary>
    /// Versicherungsverbindlichkeiten
    /// </summary>
    InsuranceLiabilities,
    /// <summary>
    /// Versicherungsbeiträge
    /// </summary>
    InsurancePremium,
    /// <summary>
    /// Gezahlte Versicherungsbeiträge
    /// </summary>
    InsurancePremiumPayed,
    /// <summary>
    /// Zinsen
    /// </summary>
    InterestExpenses,
    /// <summary>
    /// Pflichtteilsforderung
    /// </summary>
    LegalPortionRequest,
    /// <summary>
    /// Pflichtteilsforderungen
    /// </summary>
    LegalPortionWeight,
    /// <summary>
    /// Werbungskosten
    /// </summary>
    LettingAndLeasingAdvertisingCosts,
    /// <summary>
    /// Vermietung und Verpachtung
    /// </summary>
    LettingAndLeasingIncome,
    /// <summary>
    /// Immobilie (1 - n)
    /// </summary>
    LettingAndLeasingItem,
    /// <summary>
    /// Verbindlichkeiten
    /// </summary>
    Liabilities,
    /// <summary>
    /// Lebensführung
    /// </summary>
    LivingExpenses,
    /// <summary>
    /// Ausgereichtes Darlehen
    /// </summary>
    LoanGranted,
    /// <summary>
    /// Verlustverrechnung
    /// </summary>
    LossAdjustment,
    /// <summary>
    /// Einkünfte aus betrieblichem Minijob
    /// </summary>
    MinijobOrdinaryIncome,
    /// <summary>
    /// Einkünfte aus privatem Minijob
    /// </summary>
    MinijobPrivatIncome,
    /// <summary>
    /// Minimum Brutto / Netto
    /// </summary>
    MinimumBruttoNetto,
    /// <summary>
    /// Sonstiges
    /// </summary>
    MiscellaneousIncome,
    /// <summary>
    /// Bemessungsgrundlage
    /// </summary>
    NursingCareAssessment,
    /// <summary>
    /// Gesetzliche Pflegeversicherung
    /// </summary>
    NursingCareInsurance,
    /// <summary>
    /// Allgemeiner Beitragssatz
    /// </summary>
    NursingCareInsuranceRate,
    /// <summary>
    /// Arbeitgeberanteil
    /// </summary>
    NursingCareRefund,
    /// <summary>
    /// Bemessungsgrundlage
    /// </summary>
    NursingCareRefundBase,
    /// <summary>
    /// Sozialversicherungspflichtig
    /// </summary>
    NursingCareSocialSecurityIncome,
    /// <summary>
    /// Sonstiges Vermögen
    /// </summary>
    OtherAssets,
    /// <summary>
    /// Sonstige Ausgaben
    /// </summary>
    OtherExpenses,
    /// <summary>
    /// Werbungskosten
    /// </summary>
    OtherIncomeAdvertisingCosts,
    /// <summary>
    /// Sonstige Versicherungen
    /// </summary>
    OtherInsurances,
    /// <summary>
    /// Sonstige Verbindlichkeiten
    /// </summary>
    OtherLiabilities,
    /// <summary>
    /// Sonstige Einnahmen
    /// </summary>
    OtherRetirementIncome,
    /// <summary>
    /// Sonstige Wertpapiere
    /// </summary>
    OtherSecurities,
    /// <summary>
    /// Sonstige Vorsorgeaufwendungen
    /// </summary>
    OtherSupply,
    /// <summary>
    /// Sonstige Sonderausgaben
    /// </summary>
    OtherTaxableExpenses,
    /// <summary>
    /// Eigengenutzte Immobilien
    /// </summary>
    OwnerProperties,
    /// <summary>
    /// Beteiligungsverbindlichkeiten
    /// </summary>
    ParticipationLiabilities,
    /// <summary>
    /// Beteiligungen
    /// </summary>
    Participations,
    /// <summary>
    /// Basisrente
    /// </summary>
    PayedBasicPension,
    /// <summary>
    /// Erhaltenes Kindergeld
    /// </summary>
    PayedChildBenefits,
    /// <summary>
    /// Gezahlte Beiträge zur bAV
    /// </summary>
    PayedCompanyPensionPremius,
    /// <summary>
    /// Rentenzahlungen
    /// </summary>
    PayedMonthlyPension,
    /// <summary>
    /// Gesetzliche Rentenversicherung
    /// </summary>
    PayedPensionContributions,
    /// <summary>
    /// Eingezahlte Beiträge
    /// </summary>
    PayedPremium,
    /// <summary>
    /// Rente aus Versorgungswerk
    /// </summary>
    PayedProfessionalPension,
    /// <summary>
    /// Werbungskosten
    /// </summary>
    PensionAdvertisingCosts,
    /// <summary>
    /// Freibetrag
    /// </summary>
    PensionAllowance,
    /// <summary>
    /// Bemessungsgrundlage
    /// </summary>
    PensionAssessment,
    /// <summary>
    /// Gezahlte Beiträge
    /// </summary>
    PensionContributions,
    /// <summary>
    /// Kürzung
    /// </summary>
    PensionContributionsLimitReduction,
    /// <summary>
    /// Höchstbetrag
    /// </summary>
    PensionContributionsMaximum,
    /// <summary>
    /// Rente
    /// </summary>
    PensionIncome,
    /// <summary>
    /// Gesetzliche Rentenversicherung
    /// </summary>
    PensionInsurance,
    /// <summary>
    /// Rentenversicherung bei betrieblichen Minijobs
    /// </summary>
    PensionInsuranceMinijobOrdinary,
    /// <summary>
    /// Rentenversicherung bei privaten Minijobs
    /// </summary>
    PensionInsuranceMinijobPrivat,
    /// <summary>
    /// Arbeitgeberanteil
    /// </summary>
    PensionInsuranceRefund,
    /// <summary>
    /// Bemessungsgrundlage
    /// </summary>
    PensionInsuranceRefundBase,
    /// <summary>
    /// Altersvorsorge
    /// </summary>
    PensionPlan,
    /// <summary>
    /// Altersvorsorge
    /// </summary>
    PensionPlanExpenses,
    /// <summary>
    /// Sozialversicherungspflichtig
    /// </summary>
    PensionSocialSecurityIncome,
    /// <summary>
    /// Altersvorsorgeaufwendungen
    /// </summary>
    PensionSupply,
    /// <summary>
    /// Anteil
    /// </summary>
    PercentageCalculation,
    /// <summary>
    /// Personenversicherungen
    /// </summary>
    PersonalInsurances,
    /// <summary>
    /// Mitgliedsbeiträge an politische Parteien
    /// </summary>
    PoliticalPartyMemberships,
    /// <summary>
    /// Gezahlte Beiträge
    /// </summary>
    PoliticalPartyMembershipsExpenses,
    /// <summary>
    /// Gesetzliche Pflegeversicherung
    /// </summary>
    PremiumNurseCareInsurance,
    /// <summary>
    /// Sonstige Versicherungen
    /// </summary>
    PremiumOther,
    /// <summary>
    /// Krankenversicherungsbeiträge
    /// </summary>
    PrivateHealthCareContributions,
    /// <summary>
    /// Arbeitgeberbeiträge
    /// </summary>
    PrivateHealthCareEmployer,
    /// <summary>
    /// Private Krankenversicherungen
    /// </summary>
    PrivateHealthInsurances,
    /// <summary>
    /// Private Altersvorsorge
    /// </summary>
    PrivateInsurences,
    /// <summary>
    /// Pflegeversicherungsbeiträge
    /// </summary>
    PrivateNurseCareCareContributions,
    /// <summary>
    /// Arbeitgeberbeiträge
    /// </summary>
    PrivateNurseCareCareEmployer,
    /// <summary>
    /// Private Pflegeversicherungen
    /// </summary>
    PrivateNurseCareInsurances,
    /// <summary>
    /// Private Altersvorsorge
    /// </summary>
    PrivatePension,
    /// <summary>
    /// Private Altersvorsorge
    /// </summary>
    PrivatePensionScheme,
    /// <summary>
    /// Ertragsanteil
    /// </summary>
    ProfitShareRate,
    /// <summary>
    /// Progressionsvorbehalt
    /// </summary>
    ProgressionClause,
    /// <summary>
    /// Immobilien
    /// </summary>
    Properties,
    /// <summary>
    /// Abschreibungen
    /// </summary>
    PropertyAmortization,
    /// <summary>
    /// Sachversicherungen
    /// </summary>
    PropertyInsurances,
    /// <summary>
    /// Zinsen
    /// </summary>
    PropertyInterests,
    /// <summary>
    /// Immobilienverbindlichkeiten
    /// </summary>
    PropertyLiabilities,
    /// <summary>
    /// Rücklagen
    /// </summary>
    PropertyMaintenanceReserves,
    /// <summary>
    /// Betriebskosten
    /// </summary>
    PropertyOperatingCosts,
    /// <summary>
    /// Mieteinnahmen
    /// </summary>
    PropertyRentalIncome,
    /// <summary>
    /// Immobilie (1 - n)
    /// </summary>
    PropertyTaxableItem,
    /// <summary>
    /// Vorsorgeaufwendungen
    /// </summary>
    ProvidentExpenses,
    /// <summary>
    /// Fremdgenutzte Immobilien
    /// </summary>
    RentalProperties,
    /// <summary>
    /// Tilgung
    /// </summary>
    Repayments,
    /// <summary>
    /// Gesamte Ausgaben
    /// </summary>
    RetirementGapExpenses,
    /// <summary>
    /// Gesamte Einnahmen
    /// </summary>
    RetirementGapIncome,
    /// <summary>
    /// Einnahmen
    /// </summary>
    RetirementIncome,
    /// <summary>
    /// Überschuss / Unterdeckung
    /// </summary>
    RetirementLiquidity,
    /// <summary>
    /// Altersentlastung
    /// </summary>
    RetirementRelief,
    /// <summary>
    /// Einkünfte
    /// </summary>
    RetirementReliefIncome,
    /// <summary>
    /// Person (1 - n)
    /// </summary>
    RetirementReliefItem,
    /// <summary>
    /// Zulagen
    /// </summary>
    RiesterBonus,
    /// <summary>
    /// Zulagenanteil
    /// </summary>
    RiesterBonusPercentage,
    /// <summary>
    /// Nettoeigenbeiträge
    /// </summary>
    RiesterContributions,
    /// <summary>
    /// Mindesteigenbeitrag
    /// </summary>
    RiesterMinimumContributions,
    /// <summary>
    /// Riesterverträge
    /// </summary>
    RiesterSupply,
    /// <summary>
    /// Person (1 - n)
    /// </summary>
    RiesterSupplyItem,
    /// <summary>
    /// Spareinlagen
    /// </summary>
    SavingDeposits,
    /// <summary>
    /// Schulgelder
    /// </summary>
    SchoolFees,
    /// <summary>
    /// Gezahlte Schulgelder
    /// </summary>
    SchoolFeesPayed,
    /// <summary>
    /// Wertpapiere
    /// </summary>
    Securities,
    /// <summary>
    /// Werbungskosten
    /// </summary>
    SelfEmployedAdvertisingCosts,
    /// <summary>
    /// Selbständige Tätigkeit
    /// </summary>
    SelfEmployedIncome,
    /// <summary>
    /// Krankengeld
    /// </summary>
    SicknessBenefit,
    /// <summary>
    /// 70% vom Bruttoeinkommen
    /// </summary>
    SicknessBrutto70,
    /// <summary>
    /// Nettoeinkommen
    /// </summary>
    SicknessNetto,
    /// <summary>
    /// 90% vom Nettoeinkommen
    /// </summary>
    SicknessNetto90,
    /// <summary>
    /// Sozialabgaben
    /// </summary>
    SicknessSocialContributions,
    /// <summary>
    /// Zu versteuern
    /// </summary>
    SicknessTaxable,
    /// <summary>
    /// Steuern
    /// </summary>
    SicknessTaxes,
    /// <summary>
    /// Anteil
    /// </summary>
    SicknessYearPart,
    /// <summary>
    /// Sozialabgaben
    /// </summary>
    SocialContributions,
    /// <summary>
    /// Person (1 - n)
    /// </summary>
    SocialContributionsItem,
    /// <summary>
    /// Betriebliche Kapitalversicherungen
    /// </summary>
    SocialSecurityCompanyPension,
    /// <summary>
    /// Sozialversicherungspflichtige bAV
    /// </summary>
    SocialSecurityContributions,
    /// <summary>
    /// Sozialversicherungsfrei
    /// </summary>
    SocialSecurityLimit,
    /// <summary>
    /// Pensionszusage
    /// </summary>
    SocialSecurityPensionCommitment,
    /// <summary>
    /// Unterstützungskasse
    /// </summary>
    SocialSecurityProvidentFund,
    /// <summary>
    /// Auf Kapitalerträge
    /// </summary>
    SolidarityCapitalIncome,
    /// <summary>
    /// Bemessungsgrundlage
    /// </summary>
    SolidarityIncome,
    /// <summary>
    /// Einkommensteuer
    /// </summary>
    SolidarityIncomeTax,
    /// <summary>
    /// Auf Einkünfte
    /// </summary>
    SolidarityOtherIncome,
    /// <summary>
    /// Solidaritätszuschlag
    /// </summary>
    SolidarityTax,
    /// <summary>
    /// Kinderfreibetrag
    /// </summary>
    SolidarityTaxChildAllowance,
    /// <summary>
    /// Außergewöhnliche Belastungen in besonderen Fällen
    /// </summary>
    SpecialExceptionalCosts,
    /// <summary>
    /// Gezahlte außergewöhnliche Belastungen
    /// </summary>
    SpecialExceptionalCostsPayed,
    /// <summary>
    /// Mitgliedsbeiträge an politische Parteien
    /// </summary>
    SpecialPoliticalPartyMemberships,
    /// <summary>
    /// Gesetzliche Altersvorsorge
    /// </summary>
    StatePensionScheme,
    /// <summary>
    /// Gesetzliche Altersvorsorge
    /// </summary>
    StatutoryPension,
    /// <summary>
    /// Versorgungslücke
    /// </summary>
    SupplyGap,
    /// <summary>
    /// Zu versteuerndes Einkommen
    /// </summary>
    Taxable,
    /// <summary>
    /// Land- und Forstwirtschaft
    /// </summary>
    TaxableAgricultureIncome,
    /// <summary>
    /// Gewerbebetrieb
    /// </summary>
    TaxableBusinessIncome,
    /// <summary>
    /// Kapitalvermögen
    /// </summary>
    TaxableCapitalIncome,
    /// <summary>
    /// Kapitalauszahlung Lebensversicherung (1 - n)
    /// </summary>
    TaxableCapitalPaymentItem,
    /// <summary>
    /// Zu versteuernde bAV-Beiträge
    /// </summary>
    TaxableCompanyPensionPremiums,
    /// <summary>
    /// Nichtselbständige Arbeit
    /// </summary>
    TaxableEmployedIncome,
    /// <summary>
    /// Person (1 - n)
    /// </summary>
    TaxableEmployedIncomeItem,
    /// <summary>
    /// Arbeitslohn
    /// </summary>
    TaxableEmployedPayment,
    /// <summary>
    /// Versorgungsbezüge
    /// </summary>
    TaxableEmployedPension,
    /// <summary>
    /// Sonderausgaben
    /// </summary>
    TaxableExpenses,
    /// <summary>
    /// Weitere Einkünfte
    /// </summary>
    TaxableFurtherIncome,
    /// <summary>
    /// Einkünfte
    /// </summary>
    TaxableIncome,
    /// <summary>
    /// Vermietung und Verpachtung
    /// </summary>
    TaxableLettingAndLeasing,
    /// <summary>
    /// Sonstige Einkünfte
    /// </summary>
    TaxableOtherIncome,
    /// <summary>
    /// Person (1 - n)
    /// </summary>
    TaxableOtherIncomeItem,
    /// <summary>
    /// Rentenzahlungen
    /// </summary>
    TaxablePensionIncome,
    /// <summary>
    /// Rentenzahlung aus Schicht 1 (1 - n)
    /// </summary>
    TaxablePensionLayer1Item,
    /// <summary>
    /// Rentenzahlung aus Schicht 3 (1 - n)
    /// </summary>
    TaxablePensionLayer3Item,
    /// <summary>
    /// Selbständige Arbeit
    /// </summary>
    TaxableSelfEmployedIncome,
    /// <summary>
    /// Zu versteuernder Gewerbeertrag
    /// </summary>
    TaxableTradeIncome,
    /// <summary>
    /// Kapitalauszahlung Lebensversicherung (1 - n)
    /// </summary>
    TaxableWithholdingPaymentItem,
    /// <summary>
    /// Steuergutschrift
    /// </summary>
    TaxCredit,
    /// <summary>
    /// Steuergutschriften
    /// </summary>
    TaxCredits,
    /// <summary>
    /// Steuern
    /// </summary>
    Taxes,
    /// <summary>
    /// Person (1 - n)
    /// </summary>
    TaxesItem,
    /// <summary>
    /// Termineinlagen
    /// </summary>
    TimeDeposits,
    /// <summary>
    /// Gewerbeertrag (gerundet)
    /// </summary>
    TradeIncome,
    /// <summary>
    /// Steuermessbetrag
    /// </summary>
    TradeTaxBase,
    /// <summary>
    /// Gewerbesteueranrechnung
    /// </summary>
    TradeTaxCredit,
    /// <summary>
    /// Steuermessbeträge
    /// </summary>
    TradeTaxCreditBase,
    /// <summary>
    /// Gewerbesteueranrechnung (1 - n)
    /// </summary>
    TradeTaxCreditItem,
    /// <summary>
    /// Anrechenbarer Hebesatz
    /// </summary>
    TradeTaxCreditRate,
    /// <summary>
    /// Gewerbesteuer
    /// </summary>
    TradeTaxes,
    /// <summary>
    /// Gewerbebetrieb (1 - n)
    /// </summary>
    TradeTaxItem,
    /// <summary>
    /// Hebesatz
    /// </summary>
    TradeTaxMultiplier,
    /// <summary>
    /// Gezahlter Hebesatz
    /// </summary>
    TradeTaxPayedCreditRate,
    /// <summary>
    /// Bemessungsgrundlage
    /// </summary>
    UnemploymentAssessment,
    /// <summary>
    /// Arbeitslosenversicherung
    /// </summary>
    UnemploymentInsurance,
    /// <summary>
    /// Arbeitgeberanteil
    /// </summary>
    UnemploymentInsuranceRefund,
    /// <summary>
    /// Bemessungsgrundlage
    /// </summary>
    UnemploymentInsuranceRefundBase,
    /// <summary>
    /// Sozialversicherungspflichtig
    /// </summary>
    UneploymentSocialSecurityIncome,
    /// <summary>
    /// Berufsausbildungskosten
    /// </summary>
    VocationalTrainingCosts,
    /// <summary>
    /// Gezahlte Berufsausbildungskosten
    /// </summary>
    VocationalTrainingPayed,
    /// <summary>
    /// Entgeltersatzleistungen
    /// </summary>
    WageReplacement,
    /// <summary>
    /// Einkünfte
    /// </summary>
    WidowsAssetsIncome,
    /// <summary>
    /// Vermögenserträge
    /// </summary>
    WidowsAssetsReduction,
    /// <summary>
    /// Einkünfte
    /// </summary>
    WidowsCivilServantIncome,
    /// <summary>
    /// Beamtenpensionen
    /// </summary>
    WidowsCivilServantReduction,
    /// <summary>
    /// Einkünfte
    /// </summary>
    WidowsCompanyPensionIncome,
    /// <summary>
    /// Betriebliche Altersvorsorge
    /// </summary>
    WidowsCompanyPensionReduction,
    /// <summary>
    /// Einkünfte
    /// </summary>
    WidowsEarnedIncome,
    /// <summary>
    /// Arbeitseinkommen
    /// </summary>
    WidowsEarnedReduction,
    /// <summary>
    /// Einkünfte
    /// </summary>
    WidowsMinijobIncome,
    /// <summary>
    /// Minijob
    /// </summary>
    WidowsMinijobReduction,
    /// <summary>
    /// Einkünfte
    /// </summary>
    WidowsMinijobRVIncome,
    /// <summary>
    /// Minijob rentenversichert
    /// </summary>
    WidowsMinijobRVReduction,
    /// <summary>
    /// Rentenanspruch
    /// </summary>
    WidowsPension,
    /// <summary>
    /// Freibetrag
    /// </summary>
    WidowsPensionAllowance,
    /// <summary>
    /// Freibetrag für Kinder
    /// </summary>
    WidowsPensionChildAllowance,
    /// <summary>
    /// Witwenrente (1 - n)
    /// </summary>
    WidowsPensionItem,
    /// <summary>
    /// Kürzung
    /// </summary>
    WidowsPensionReduction,
    /// <summary>
    /// Einkünfte
    /// </summary>
    WidowsPrivatePensionIncome,
    /// <summary>
    /// Private Altersvorsorge
    /// </summary>
    WidowsPrivatePensionReduction,
    /// <summary>
    /// Einkünfte
    /// </summary>
    WidowsProfessionalPensionIncome,
    /// <summary>
    /// Renten aus Versorgungswerk
    /// </summary>
    WidowsProfessionalPensionReduction,
    /// <summary>
    /// Einkünfte
    /// </summary>
    WidowsStatuoryPensionIncome,
    /// <summary>
    /// Gesetzliche Renten
    /// </summary>
    WidowsStatuoryPensionReduction,
    /// <summary>
    /// Einkünfte
    /// </summary>
    WidowsWageCompensationIncome,
    /// <summary>
    /// Entgeltersatzleistungen
    /// </summary>
    WidowsWageCompensationReduction,
    /// <summary>
    /// Einkünfte
    /// </summary>
    WidowsWageIncome,
    /// <summary>
    /// Arbeitsentgelt
    /// </summary>
    WidowsWageReduction,
    /// <summary>
    /// Abgeltungsteuerpflichtig
    /// </summary>
    WithholdingAssessment,
    /// <summary>
    /// Abgeltungsteuerpflichtige Einkünfte
    /// </summary>
    WithholdingIncome,
    /// <summary>
    /// Verlustverrechnung
    /// </summary>
    WithholdingLossAdjustment,
    /// <summary>
    /// Abgeltungsteuer
    /// </summary>
    WithholdingTax,
    /// <summary>
    /// Einkommensteuerpflichtig
    /// </summary>
    WithholdingTaxableIncome
}
