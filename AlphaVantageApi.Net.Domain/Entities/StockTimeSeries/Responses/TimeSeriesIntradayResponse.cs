using System.Collections.Generic;

namespace AlphaVantageApi.Net.Domain.Entities.StockTimeSeries.Responses
{
    public class TimeSeriesIntradayResponse
    {
        public MetaData MetaData { get; set; }
        public List<TimeSeries> TimeSeries { get; set; }
        public TimeSeriesIntradayResponse()
        {
            TimeSeries = new List<TimeSeries>();
        }
    }
}
