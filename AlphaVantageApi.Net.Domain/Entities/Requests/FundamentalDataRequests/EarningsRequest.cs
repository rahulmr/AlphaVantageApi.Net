using AlphaVantageApi.Net.Domain.Enums;

namespace AlphaVantageApi.Net.Domain.Entities.Requests.FundamentalDataRequests
{
    public class EarningsRequest : RequestModelBase
    {
        public string Symbol { get; }

        public EarningsRequest(string symbol) : base(Function.EARNINGS)
        {
            Symbol = symbol;
        }
    }
}
