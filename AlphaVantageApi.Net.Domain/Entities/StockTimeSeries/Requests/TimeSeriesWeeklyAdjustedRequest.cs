using AlphaVantageApi.Net.Domain.Enums;

namespace AlphaVantageApi.Net.Domain.Entities.StockTimeSeries.Requests
{
    public class TimeSeriesWeeklyAdjustedRequest : RequestModelBase
    {
        public string Symbol { get; }
        public DataType DataType { get; }

        public TimeSeriesWeeklyAdjustedRequest(string symbol, DataType dataType = DataType.Json)
            : base(Function.TIME_SERIES_WEEKLY_ADJUSTED)
        {
            Symbol = symbol;
            DataType = dataType;
        }
    }
}
