using System;

namespace AlphaVantageApi.Net.Domain.Entities.FundamentalData.Responses
{
    public class QuarterlyEarning
    {
        public DateTime FiscalDateEnding { get; set; }
        public DateTime ReportedDate { get; set; }
        public decimal ReportedEPS { get; set; }
        public decimal EstimatedEPS { get; set; }
        public decimal Surprise { get; set; }
        public decimal SurprisePercentage { get; set; }
    }
}
