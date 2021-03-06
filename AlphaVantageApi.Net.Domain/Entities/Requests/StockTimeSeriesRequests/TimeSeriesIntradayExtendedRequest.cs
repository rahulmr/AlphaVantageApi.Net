using AlphaVantageApi.Net.Domain.Enums;

namespace AlphaVantageApi.Net.Domain.Entities.Requests.StockTimeSeriesRequests
{
    public class TimeSeriesIntradayExtendedRequest : RequestModelBase
    {
        public string Symbol { get; set; }
        public Interval Interval { get; set; }
        public Slice Slice { get; set; }
        public bool Adjusted { get; set; }
        public OutputSize OutputSize { get; set; }
        public DataType DataType { get; set; }

        public TimeSeriesIntradayExtendedRequest(string symbol, Interval interval,
            bool adjusted = true, OutputSize outputSize = OutputSize.Compact, DataType dataType = DataType.Json)
            : base(Function.TIME_SERIES_INTRADAY_EXTENDED)
        {
            Symbol = symbol;
            Interval = interval;
            Adjusted = adjusted;
            OutputSize = outputSize;
            DataType = dataType;
        }
    }
}
