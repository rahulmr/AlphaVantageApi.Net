using AlphaVantageApi.Net.Domain.Enums;

namespace AlphaVantageApi.Net.Domain.Entities.Requests.FundamentalDataRequests
{
    public class BalanceSheetRequest : RequestModelBase
    {
        public string Symbol { get; }

        public BalanceSheetRequest(string symbol) 
            : base(Function.BALANCE_SHEET)
        {
            Symbol = symbol;
        }
    }
}
