using AlphaVantageApi.Net.Domain.Enums;

namespace AlphaVantageApi.Net.Domain.Entities.StockTimeSeries.Requests
{
    public class TimeSeriesMonthlyRequest : RequestModelBase
    {
        public string Symbol { get; }
        public DataType DataType { get; }

        public TimeSeriesMonthlyRequest(string symbol, DataType dataType = DataType.Json)
            : base(Function.TIME_SERIES_MONTHLY)
        {
            Symbol = symbol;
            DataType = dataType;
        }
    }
}
