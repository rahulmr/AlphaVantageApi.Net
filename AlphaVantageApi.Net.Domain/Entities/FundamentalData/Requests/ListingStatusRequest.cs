using AlphaVantageApi.Net.Domain.Enums;
using System;

namespace AlphaVantageApi.Net.Domain.Entities.FundamentalData.Requests
{
    public class ListingStatusRequest : RequestModelBase
    {
        public string Symbol { get; }
        public DateTime? Date { get; } // YYYY-MM-DD > 2010-01-01
        public State State { get; }
        public ListingStatusRequest(string symbol, DateTime? date = null, State state = State.Active)
            : base(Function.LISTING_STATUS)
        {
            Symbol = symbol;
            Date = date;
            State = state;
        }
    }
}
