using AlphaVantageApi.Net.Domain.Enums;

namespace AlphaVantageApi.Net.Domain.Entities.StockTimeSeries.Requests
{
    public class QuoteEndpointRequest : RequestModelBase
    {
        public string Symbol { get; }
        public DataType DataType { get; }
        
        public QuoteEndpointRequest(string symbol, DataType dataType = DataType.Json)
             : base(Function.TIME_SERIES_MONTHLY_ADJUSTED)
        {
            Symbol = symbol;
            DataType = dataType;
        }
    }
}
