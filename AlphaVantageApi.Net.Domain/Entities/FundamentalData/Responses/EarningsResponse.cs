using System.Collections.Generic;

namespace AlphaVantageApi.Net.Domain.Entities.FundamentalData.Responses
{
    public class EarningsResponse
    {
        public string Symbol { get; set; }
        public List<AnnualEarning> AnnualEarnings { get; set; }
        public List<QuarterlyEarning> QuarterlyEarnings { get; set; }

        public EarningsResponse()
        {
            AnnualEarnings = new List<AnnualEarning>();
            QuarterlyEarnings = new List<QuarterlyEarning>();
        }
    }
}