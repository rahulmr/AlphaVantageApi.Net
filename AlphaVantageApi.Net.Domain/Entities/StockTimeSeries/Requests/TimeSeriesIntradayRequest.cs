using AlphaVantageApi.Net.Domain.Enums;

namespace AlphaVantageApi.Net.Domain.Entities.StockTimeSeries.Requests
{
    public class TimeSeriesIntradayRequest : RequestModelBase
    {
        public string Symbol { get; }
        public Interval Interval { get; }
        public bool Adjusted { get; }
        public OutputSize OutputSize { get; }
        public DataType DataType { get; }

        public TimeSeriesIntradayRequest(string symbol, Interval interval, 
            bool adjusted = true, OutputSize outputSize = OutputSize.Compact, DataType dataType = DataType.Json)
            : base(Function.TIME_SERIES_INTRADAY)
        {
            Symbol = symbol;
            Interval = interval;
            Adjusted = adjusted;
            OutputSize = outputSize;
            DataType = dataType;
        }
    }
}
