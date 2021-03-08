using AlphaVantageApi.Net.Domain.Enums;
using System;

namespace AlphaVantageApi.Net.Domain.Entities.StockTimeSeries.Responses
{
    public class MetaData
    {
        public string Info { get; set; }
        public string Symbol { get; set; }
        public DateTime LastRefreshed { get; set; }
        public string Interval { get; set; }
        public OutputSize OutputSize { get; set; }
        public TimeZoneInfo TimeZone { get; set; }
    }
}
