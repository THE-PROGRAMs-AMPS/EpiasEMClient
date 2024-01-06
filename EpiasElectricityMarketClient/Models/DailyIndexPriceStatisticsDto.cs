namespace EpiasElectricityMarketClient.Models
{
    public partial class DailyIndexPriceStatisticsDto
    {
        [Newtonsoft.Json.JsonProperty("priceTotal", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? PriceTotal { get; set; }

        [Newtonsoft.Json.JsonProperty("priceUsdTotal", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? PriceUsdTotal { get; set; }

        [Newtonsoft.Json.JsonProperty("priceEurTotal", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? PriceEurTotal { get; set; }

    }
}
