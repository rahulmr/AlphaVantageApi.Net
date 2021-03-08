namespace AlphaVantageApi.Net.Domain.Entities.StockTimeSeries.Responses
{
    public class TimeSeries
    {
        public decimal Open { get; set; }
        public decimal High { get; set; }
        public decimal Low { get; set; }
        public decimal Close { get; set; }
        public int Volume { get; set; }
    }
}
