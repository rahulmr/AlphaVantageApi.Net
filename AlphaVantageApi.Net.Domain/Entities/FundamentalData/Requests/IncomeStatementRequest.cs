using AlphaVantageApi.Net.Domain.Enums;

namespace AlphaVantageApi.Net.Domain.Entities.FundamentalData.Requests
{
    public class IncomeStatementRequest : RequestModelBase
    {
        public string Symbol { get; }

        public IncomeStatementRequest(string symbol) : base(Function.INCOME_STATEMENT)
        {
            Symbol = symbol;
        }
    }
}
