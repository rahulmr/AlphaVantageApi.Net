using AlphaVantageApi.Net.Domain.Enums;

namespace AlphaVantageApi.Net.Domain.Entities.FundamentalData.Requests
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
