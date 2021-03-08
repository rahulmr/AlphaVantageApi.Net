using System;

namespace AlphaVantageApi.Net.Domain.Entities.FundamentalData.Responses
{
    public class AnnualEarning
    {
        public DateTime FiscalDateEnding { get; set; }
        public decimal ReportedEPS { get; set; }
    }
}
