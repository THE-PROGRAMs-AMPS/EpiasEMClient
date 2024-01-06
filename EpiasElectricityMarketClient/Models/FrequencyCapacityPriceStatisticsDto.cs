namespace EpiasElectricityMarketClient.Models
{
    public partial class FrequencyCapacityPriceStatisticsDto
    {
        [Newtonsoft.Json.JsonProperty("priceAvg", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? PriceAvg { get; set; }

    }

}
