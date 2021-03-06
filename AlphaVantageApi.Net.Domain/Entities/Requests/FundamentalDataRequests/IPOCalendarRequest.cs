using AlphaVantageApi.Net.Domain.Enums;

namespace AlphaVantageApi.Net.Domain.Entities.Requests.FundamentalDataRequests
{
    public class IPOCalendarRequest : RequestModelBase
    {
        public IPOCalendarRequest() : base(Function.IPO_CALENDAR)
        {

        }
    }
}
