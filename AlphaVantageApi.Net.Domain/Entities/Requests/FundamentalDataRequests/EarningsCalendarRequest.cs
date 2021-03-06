using AlphaVantageApi.Net.Domain.Enums;

namespace AlphaVantageApi.Net.Domain.Entities.Requests.FundamentalDataRequests
{
    public class EarningsCalendarRequest : RequestModelBase
    {
        public string Symbol { get; }
        public Horizon Horizon { get; }

        public EarningsCalendarRequest(string symbol = null, Horizon horizon = Horizon.ThreeMonth)
            : base(Function.EARNINGS_CALENDAR)
        {
            Symbol = symbol;
            Horizon = horizon;
        }
    }
}
