using AlphaVantageApi.Net.Domain.Enums;

namespace AlphaVantageApi.Net.Domain.Entities.Requests.StockTimeSeriesRequests
{
    public class TimeSeriesDailyRequest : RequestModelBase
    {
        public string Symbol { get; }
        public OutputSize OutputSize { get; }
        public DataType DataType { get; }

        public TimeSeriesDailyRequest(string symbol, 
            OutputSize outputSize = OutputSize.Compact, DataType dataType = DataType.Json)
            : base (Function.TIME_SERIES_DAILY)
        {
            Symbol = symbol;
            OutputSize = outputSize;
            DataType = dataType;
        }
    }
}
