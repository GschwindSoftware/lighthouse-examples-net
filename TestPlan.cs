#pragma warning disable CA1822

using System;
using System.IO;
using System.Threading.Tasks;
using Gschwind.Lighthouse.Example.Api;
using Gschwind.Lighthouse.Example.Models.Data;
using Gschwind.Lighthouse.Example.Models.Family;
using Gschwind.Lighthouse.Example.Models.Plans;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;

namespace Gschwind.Lighthouse.Example {

    /// <summary>
    /// Demonstiert verschiedene Arten, einen Finanzplan zu laden
    /// </summary>
    internal class TestPlan {

        #region Abhängigkeiten

        readonly LighthouseApi _api;
        readonly JsonSerializerSettings _jsonSettings;
        readonly ILogger<TestPlan> _logger;

        public TestPlan(LighthouseApi api, JsonSerializerSettings jsonSettings, ILogger<TestPlan> logger) =>
            (_api, _jsonSettings, _logger) = (api, jsonSettings, logger);

        #endregion

        /// <summary>
        /// Einen Finanzplan aus einer JSON-Datei laden
        /// </summary>
        /// <param name="path">Der Pfad zu der JSON-Datei</param>
        /// <returns>
        /// Eine <see cref="Task{TResult}"/>, die den <see cref="Plan"/> oder <see langword="null"/> enthält,
        /// falls die Datei nicht existiert oder ungültig ist
        /// </returns>
        internal async Task<Plan?> FromJsonAsync(string path) {
            try {
                var json = await File.ReadAllTextAsync(path);
                return JsonConvert.DeserializeObject<Plan>(json, _jsonSettings);
            } catch (Exception e) {
                _logger.LogError(e, "Plan konnte nicht geladen werden.");
            }

            return null;
        }

        /// <summary>
        /// Einen Finanzplan programmatisch erzeugen
        /// </summary>
        /// <returns>Der erzeugte <see cref="Plan"/></returns>
        internal Plan Programmatically() {
            var client = new Customer {
                FirstName = "Max",
                LastName = "Mustermann",
                Birthday = new(1975, 05, 03),
                ChurchTaxDuty = false
            };

            var spouse = new Partner {
                FirstName = "Erika",
                LastName = "Mustermann",
                Birthday = new(1986, 10, 08),
                ChurchTaxDuty = false
            };

            return new() {
                Family = new() {
                    Members = { client, spouse },
                    Relationships = {
                        spouse.IsPartnerOf(client)
                    }
                },
                Finances = {
                    new PensionIncome {
                        Name = "Gesetzliche Rente von Max",
                        Termination = Moment.AtDate(new(2065, 05, 02)),
                        CashFlows = new() {
                            Period = Period.Yearly,
                            Values = {
                                new CashFlow() {
                                    Date = new(1970, 01, 01),
                                    Value = 3_400
                                }
                            }
                        }
                    },
                    new EmployedIncome() {
                        Name = "Gehalt von Erika",
                        CashFlows = new() {
                            Period = Period.Monthly,
                            Values = {
                                new CashFlow() {
                                    Date = new(1970, 01, 01),
                                    Value = 410.08
                                }
                            }
                        },
                        Owner = Owner.Partner,
                        Termination = Moment.AtDate(new(2046, 11, 01))
                    },
                    new LivingCosts {
                        Name = "Liquiditätsbedarf im Ruhestand",
                        CashFlows = new() {
                            Period = Period.Yearly,
                            Values = {
                                new() {
                                    Date = new(1970, 01, 01),
                                    Value = 36_000
                                }
                            }
                        },
                        Owner = Owner.Both(),
                        Termination = Moment.AtDate(new(2065, 05, 02))
                    },
                    new Deposit() {
                        Name = "Depot",
                        Securities = {
                            new() {
                                Name = "Deutsche Bank Aktiengesellschaft",
                                Appreciations = {
                                    new() {
                                        Date = new(2021, 01, 01),
                                        Value = 3.0
                                    }
                                },
                                Buying = new() {
                                    PurchaseDate = new(2021, 01, 01)
                                },
                                DividendPayout = new(2018, 12, 31),
                                Dividends = {
                                    new() {
                                        Date = new(2021, 01, 01),
                                        Value = 2.0
                                    }
                                },
                                Industries = {
                                    new() {
                                        Name = "Finanzwesen",
                                        Quote = 100.0
                                    }
                                },
                                Isin = "DE0005140008",
                                MaturityDate = new(2081, 12, 31),
                                Quantity = 500,
                                Regions = {
                                    new() {
                                        Name = "Deutschland",
                                        Quote = 100.0
                                    }
                                },
                                ReinvestDividends = true,
                                RiskLevel = RiskLevel.NotCritical,
                                SecurityPrice = 10.48,
                                SecurityType = SecurityType.Stock,
                                ValueDate = new(2021, 07, 13)
                            }
                        }
                    },
                    new CheckingAccount() {
                        Name = "Girokonto",
                        AccountBalance = 3_500,
                        InterestPeriod = Period.Quarterly,
                        InvestmentType = InvestmentType.Stock,
                        Owner = Owner.Both(),
                        RiskLevel = RiskLevel.NotCritical,
                        TimePeriod = new() {
                            StartDate = new(2018, 01, 01),
                            EndDate = new(2031, 01, 01)
                        },
                        ValueDate = new(2018, 01, 01)
                    },
                    new PensionFund() {
                        Name = "Pensionsfonds Max",
                        CalculationParameter = new() {
                            AcquisitionCosts = 0,
                            CapitalInterest = 3.8
                        },
                        CapitalPayment = 63_932.50,
                        CapitalPremium = new() {
                            Period = Period.Yearly,
                            Values = {
                                new() {
                                    Date = new(2018, 03, 02),
                                    Value = 80
                                }
                            }
                        },
                        InceptionDate = new(2018, 03, 01),
                        InsuranceCompany = "Telekom",
                        InsurancePayoutType = InsurancePayoutType.CapitalPayment,
                        InsuredPerson = client.Id,
                        PayoutMoment = Moment.AtDate(new(2039, 01, 01)),
                        Pension = 412.47,
                        PensionIncrease = 1.0,
                        PensionLimitation = new(2027, 12, 31),
                        RepurchaseValues = {
                            new() {
                                Date = new(2018, 01, 01),
                                Value = 15_550
                            }
                        }
                    },
                    new StatutoryPension() {
                        Name = "Gesetzliche Rente Erika",
                        Owner = Owner.Partner,
                        PayoutMoment = Moment.AtDate(new(2053, 11, 01)),
                        PensionValue = 2_080,
                        ValueDate = new(2018, 05, 01)
                    },
                    new PrivatePensionInsurance() {
                        Name = "Rentenversicherung Max",
                        AdditionalPayments = {
                            new() {
                                Date = new(2065, 05, 03),
                                Value = 43_777
                            }
                        },
                        CalculatePayout = false,
                        InceptionDate = new(2018, 01, 01),
                        InsuranceCompany = "Debeka",
                        InsurancePayoutType = InsurancePayoutType.MonthlyPension,
                        InsuredPerson = client.Id,
                        Owner = Owner.Client,
                        PayoutMoment = Moment.AtDate(new(2040, 12, 01)),
                        Pension = 241.62,
                        PensionGaranteeYears = 0
                    },
                    new RiesterPension() {
                        Name = "Riesterrente Max",
                        CalculatePayout = false,
                        InceptionDate = new(2018, 01, 01),
                        InsuranceCompany = "Debeka",
                        Owner = Owner.Client,
                        PayoutMoment = Moment.AtDate(new(2042, 06, 01)),
                        Pension = 333.59
                    },
                    new PensionScheme() {
                        Name = "Pensionskasse Erika",
                        CalculatePayout = false,
                        InceptionDate = new(2018, 01, 01),
                        InsuranceCompany = "BVV",
                        InsuredPerson = spouse.Id,
                        PayoutMoment = Moment.AtDate(new(2049, 11, 01)),
                        Pension = 158.42,
                        PensionIncrease = 1.0,
                        PensionLimitation = new(2080, 12, 31)
                    },
                    new PensionCommitment() {
                        Name = "Pensionszusage Max",
                        CapitalPayment = 135_138,
                        InsuranceCompany = "Telekom",
                        InsurancePayoutType = InsurancePayoutType.CapitalPayment,
                        IsFifthPartRule = true,
                        Owner = Owner.Client,
                        PayoutMoment = new() {
                            Type = MomentType.AtRetirement
                        },
                        Pension = 1_000,
                        PensionLimitation = new(2080, 12, 31),
                        PremiumPayment = PremiumPayment.Employer
                    }
                }
            };
        }

        /// <summary>
        /// Einen im Web Service abgespeicherten Finanzplan abrufen
        /// </summary>
        /// <param name="planId">Eindeutiger Schlüssel des Finanzplans</param>
        /// <returns>
        /// Eine <see cref="Task{TResult}"/>, die den <see cref="Plan"/> oder <see langword="null"/> enthält,
        /// falls dieser nicht existiert
        /// </returns>
        internal async Task<Plan?> FromApiAsync(int planId) {
            var response = await _api.Plans.GetAsync(planId);
            return response.IsSuccessStatusCode ?
                response.Content : null;
        }

    }

}

#pragma warning restore
