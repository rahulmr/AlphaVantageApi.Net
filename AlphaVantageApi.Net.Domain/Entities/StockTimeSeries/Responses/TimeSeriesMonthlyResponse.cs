using System.Collections.Generic;

namespace AlphaVantageApi.Net.Domain.Entities.StockTimeSeries.Responses
{
    public class TimeSeriesMonthlyResponse
    {
        public MetaData MetaData { get; set; }
        public List<TimeSeries> TimeSeries { get; set; }
        public TimeSeriesMonthlyResponse()
        {
            TimeSeries = new List<TimeSeries>();
        }
    }
}
