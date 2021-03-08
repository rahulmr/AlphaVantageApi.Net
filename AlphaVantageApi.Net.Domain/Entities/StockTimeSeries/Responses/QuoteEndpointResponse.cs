using System;

namespace AlphaVantageApi.Net.Domain.Entities.StockTimeSeries.Responses
{
    public class QuoteEndpointResponse
    {
        public string Symbol { get; set; }
        public decimal Open { get; set; }
        public decimal Close { get; set; }
        public decimal High { get; set; }
        public decimal Low { get; set; }
        public decimal Price { get; set; }
        public int Volume { get; set; }
        public DateTime LastTradingDay { get; set; }
        public decimal PreviousClose { get; set; }
        public decimal Change { get; set; }
        public decimal ChangePercent { get; set; }
    }
}
