using AlphaVantageApi.Net.Domain.Enums;

namespace AlphaVantageApi.Net.Domain.Entities.FundamentalData.Requests
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
