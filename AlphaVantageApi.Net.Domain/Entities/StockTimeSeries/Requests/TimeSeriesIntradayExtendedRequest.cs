using AlphaVantageApi.Net.Domain.Enums;

namespace AlphaVantageApi.Net.Domain.Entities.StockTimeSeries.Requests
{
    public class TimeSeriesIntradayExtendedRequest : RequestModelBase
    {
        public string Symbol { get; }
        public Interval Interval { get; }
        public Slice Slice { get; }
        public bool Adjusted { get; }
        public OutputSize OutputSize { get; }

        public TimeSeriesIntradayExtendedRequest(string symbol, Interval interval,
            bool adjusted = true, OutputSize outputSize = OutputSize.Compact)
            : base(Function.TIME_SERIES_INTRADAY_EXTENDED)
        {
            Symbol = symbol;
            Interval = interval;
            Adjusted = adjusted;
            OutputSize = outputSize;
        }
    }
}
