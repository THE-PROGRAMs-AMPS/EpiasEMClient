namespace EpiasElectricityMarketClient.Models
{

    public partial class TradeValueStatisticsDto
    {
        [Newtonsoft.Json.JsonProperty("tradingVolumeTotal", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? TradingVolumeTotal { get; set; }

    }
}
