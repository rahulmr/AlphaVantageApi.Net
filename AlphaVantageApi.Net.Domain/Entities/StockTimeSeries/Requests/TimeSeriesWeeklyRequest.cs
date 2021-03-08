using AlphaVantageApi.Net.Domain.Enums;

namespace AlphaVantageApi.Net.Domain.Entities.StockTimeSeries.Requests
{
    public class TimeSeriesWeeklyRequest : RequestModelBase
    {
        public string Symbol { get; }
        public DataType DataType { get; }

        public TimeSeriesWeeklyRequest(string symbol, DataType dataType = DataType.Json)
            : base(Function.TIME_SERIES_WEEKLY)
        {
            Symbol = symbol;
            DataType = dataType;
        }
    }
}
