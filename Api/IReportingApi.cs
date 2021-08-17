using System.Threading.Tasks;
using Gschwind.Lighthouse.Example.Models.Report;
using Gschwind.Lighthouse.Example.Models.Reports;
using Refit;

namespace Gschwind.Lighthouse.Example.Api {

    /// <summary>
    /// Definiert die Schnittstelle der Reporting-Endpunkte der Financial Lighthouse Rechenkern API
    /// </summary>
    /// <seealso href="https://api.financial-lighthouse.de/fin/swagger/index.html"/>
    /// <seealso href="https://reactiveui.github.io/refit/"/>
    public interface IReportingApi {

        /// <summary>
        /// Liquiditätsauswertung erstellen zu einem angehängten Plan
        /// </summary>
        /// <param name="type">Typ der Liquiditätsauswertung</param>
        /// <param name="parameters">Der Plan, der die Vorgänge zur Erstellung der Liquiditätsauswertung enthält</param>
        /// <returns>Eine Aufgabe, die die Antwort der Abfrage enthält</returns>
        [Post("/liquidity/{type}")]
        Task<ApiResponse<Report>> GenerateLiquidityReportAsync(ReportPlanParameters parameters, LiquidityReportType type = LiquidityReportType.Liquidity);

        /// <summary>
        /// Vermögensauswertung erstellen zu einem angehängten Plan
        /// </summary>
        /// <param name="type">Typ der Vermögensauswertung</param>
        /// <param name="parameters">Der Plan, der die Vorgänge zur Erstellung der Vermögensauswertung enthält</param>
        /// <returns>Eine Aufgabe, die die Antwort der Abfrage enthält</returns>
        [Post("/balance/{type}")]
        Task<ApiResponse<Report>> GenerateBalanceReportAsync(ReportPlanParameters parameters, BalanceReportType type = BalanceReportType.Balance);

        /// <summary>
        /// Steuerauswertung erstellen zu einem angehängten Plan
        /// </summary>
        /// <param name="type">Typ der Steuerauswertung</param>
        /// <param name="parameters">Der Plan, der die Vorgänge zur Erstellung der Steuerauswertung enthält</param>
        /// <returns>Eine Aufgabe, die die Antwort der Abfrage enthält</returns>
        [Post("/taxes/{type}")]
        Task<ApiResponse<Report>> GenerateTaxReportAsync(ReportPlanParameters parameters, TaxReportType type = TaxReportType.Taxes);

        /// <summary>
        /// Nachfolgeauswertung erstellen zu einem angehängten Plan
        /// </summary>
        /// <param name="type">Typ der Nachfolgeauswertung</param>
        /// <param name="parameters">Der Plan, der die Vorgänge zur Erstellung der Nachfolgeauswertung enthält</param>
        /// <returns>Eine Aufgabe, die die Antwort der Abfrage enthält</returns>
        [Post("/inheritance/{type}")]
        Task<ApiResponse<Report>> GenerateInheritanceReportAsync(ReportPlanParameters parameters, InheritanceReportType type);

        /// <summary>
        /// Ruhestandsauswertung erstellen zu einem angehängten Plan
        /// </summary>
        /// <param name="type">Typ der Ruhestandsauswertung</param>
        /// <param name="parameters">Der Plan, der die Vorgänge zur Erstellung der Ruhestandsauswertung enthält</param>
        /// <returns>Eine Aufgabe, die die Antwort der Abfrage enthält</returns>
        [Post("/retirement/{type}")]
        Task<ApiResponse<Report>> GenerateRetirementReportAsync(ReportPlanParameters parameters, RetirementReportType type);

        /// <summary>
        /// Ruhestandsauswertung (Bedarf im Ruhestand) erstellen zu einem angehängten Plan
        /// </summary>
        /// <param name="type">Typ der Ruhestandsauswertung</param>
        /// <param name="parameters">Der Plan, der die Vorgänge zur Erstellung der Ruhestandsauswertung enthält</param>
        /// <returns>Eine Aufgabe, die die Antwort der Abfrage enthält</returns>
        [Post("/retirementcover/{type}")]
        Task<ApiResponse<Report>> GenerateRetirementCoverReportAsync(ReportPlanParameters parameters, RetirementReportType type);

        /// <summary>
        /// Ruhestandsauswertung (Versorgungslücke) erstellen zu einem angehängten Plan
        /// </summary>
        /// <param name="type">Typ der Ruhestandsauswertung</param>
        /// <param name="parameters">Der Plan, der die Vorgänge zur Erstellung der Ruhestandsauswertung enthält</param>
        /// <returns>Eine Aufgabe, die die Antwort der Abfrage enthält</returns>
        [Post("/retirementgap/{type}")]
        Task<ApiResponse<Report>> GenerateRetirementGapReportAsync(ReportPlanParameters parameters, RetirementReportType type);

    }

}
