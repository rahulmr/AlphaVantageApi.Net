using System.Collections.Generic;

namespace AlphaVantageApi.Net.Domain.Entities.StockTimeSeries.Responses
{
    public class TimeSeriesWeeklyResponse
    {
        public MetaData MetaData { get; set; }
        public List<TimeSeries> TimeSeries { get; set; }
        public TimeSeriesWeeklyResponse()
        {
            TimeSeries = new List<TimeSeries>();
        }
    }
}
