using AlphaVantageApi.Net.Domain.Enums;

namespace AlphaVantageApi.Net.Domain.Entities.Requests.StockTimeSeriesRequests
{
    public class TimeSeriesDailyAdjustedRequest : RequestModelBase
    {
        public string Symbol { get; }
        public OutputSize OutputSize { get; }
        public DataType DataType { get; }

        public TimeSeriesDailyAdjustedRequest(string symbol,
            OutputSize outputSize = OutputSize.Compact, DataType dataType = DataType.Json) 
            : base (Function.TIME_SERIES_DAILY_ADJUSTED)
        {
            Symbol = symbol;
            OutputSize = outputSize;
            DataType = dataType;
        }
    }
}
