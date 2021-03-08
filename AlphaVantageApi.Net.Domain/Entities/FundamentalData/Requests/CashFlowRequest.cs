using AlphaVantageApi.Net.Domain.Enums;

namespace AlphaVantageApi.Net.Domain.Entities.FundamentalData.Requests
{
    public class CashFlowRequest : RequestModelBase
    {
        public string Symbol { get; }

        public CashFlowRequest(string symbol)
            : base(Function.CASH_FLOW)
        {
            Symbol = symbol;
        }
    }
}
