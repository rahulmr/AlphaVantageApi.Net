using System.Collections.Generic;

namespace AlphaVantageApi.Net.Domain.Entities.StockTimeSeries.Responses
{
    public class SearchEndpointResponse
    {
        public List<Match> BestMatches { get; set; }

        public SearchEndpointResponse()
        {
            BestMatches = new List<Match>();
        }
    }
}
