using System.Collections.Generic;

namespace AlphaVantageApi.Net.Domain.Entities.FundamentalData.Responses
{
    public class IncomeStatementResponse
    {
        public string Symbol { get; set; }
        public List<AnnualReport> AnnualReports { get; set; }
        public List<QuarterlyReport> QuarterlyReports { get; set; }
    }
}
