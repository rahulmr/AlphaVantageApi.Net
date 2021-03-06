using AlphaVantageApi.Net.Domain.Enums;

namespace AlphaVantageApi.Net.Domain.Entities.Requests.FundamentalDataRequests
{
    public class CompanyOverviewRequest : RequestModelBase
    {
        public string Symbol { get; }

        public CompanyOverviewRequest(string symbol) 
            : base(Function.OVERVIEW)
        {
            Symbol = symbol;
        }
    }
}