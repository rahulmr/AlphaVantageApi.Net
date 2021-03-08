using System;

namespace AlphaVantageApi.Net.Domain.Entities.FundamentalData.Responses
{
    /// <summary>
    /// TODO - handle the 'None' strings returned in the Json.
    /// Don't want to say 'None' 
    /// </summary>
    public class IncomeReportBase
    {
        public DateTime FiscalDateEnding { get; set; }
        public string ReportedCurrency { get; set; }
        public int GrossProfit { get; set; }
        public int TotalRevenue { get; set; }
        public int CostOfRevenue { get; set; }
        public int CostofGoodsAndServicesSold { get; set; }
        public int OperatingIncome { get; set; }
        public int SellingGeneralAndAdministrative { get; set; }
        public int ResearchAndDevelopment { get; set; }
        public int OperatingExpenses { get; set; }
        public int InvestmentIncomeNet { get; set; }
        public string NetInterestIncome { get; set; }
        public string InterestIncome { get; set; }
        public string InterestExpense { get; set; }
        public string NonInterestIncome { get; set; }
        public string OtherNonOperatingIncome { get; set; }
        public string Depreciation { get; set; }
        public string DepreciationAndAmortization { get; set; }
        public string IncomeBeforeTax { get; set; }
        public string IncomeTaxExpense { get; set; }
        public string InterestAndDebtExpense { get; set; }
        public string NetIncomeFromContinuingOperations { get; set; }
        public string ComprehensiveIncomeNetOfTax { get; set; }
        public string Ebit { get; set; }
        public string Ebitda { get; set; }
        public string NetIncome { get; set; }
    }
}