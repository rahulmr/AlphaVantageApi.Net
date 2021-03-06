using AlphaVantageApi.Net.Domain.Enums;

namespace AlphaVantageApi.Net.Domain.Entities.Requests.StockTimeSeriesRequests
{
    public class SearchEndpointRequest : RequestModelBase
    {
        public string Keywords { get; }
        public DataType DataType { get; }

        public SearchEndpointRequest(string keywords, DataType dataType = DataType.Json) : base(Function.SYMBOL_SEARCH)
        {
            Keywords = keywords;
            DataType = dataType;
        }
    }
}
