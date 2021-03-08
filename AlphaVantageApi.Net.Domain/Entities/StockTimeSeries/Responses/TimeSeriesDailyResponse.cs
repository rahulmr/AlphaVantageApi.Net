using System.Collections.Generic;

namespace AlphaVantageApi.Net.Domain.Entities.StockTimeSeries.Responses
{
    public class TimeSeriesDailyResponse
    {
        public MetaData MetaData { get; set; }
        public List<TimeSeries> TimeSeries { get; set; }
        public TimeSeriesDailyResponse()
        {
            TimeSeries = new List<TimeSeries>();
        }
    }
}
