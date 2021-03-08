using System;

namespace AlphaVantageApi.Net.Domain.Entities.StockTimeSeries.Responses
{
    public class Match
    {
        public string Symbol { get; set; }
        public string Name { get;  }
        public string Type { get; set; }
        public string Region { get; set; }
        public decimal MarketOpen { get; set; }
        public decimal MarketClose { get; set; }
        public TimeZoneInfo Timezone { get; set; }
        public decimal Currency { get; set; }
        public decimal MatchScore { get; set; }
    }
}
