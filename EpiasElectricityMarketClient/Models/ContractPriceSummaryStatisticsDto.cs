namespace EpiasElectricityMarketClient.Models
{
    public partial class ContractPriceSummaryStatisticsDto
    {
        [Newtonsoft.Json.JsonProperty("firstMatchingPriceTotal", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? FirstMatchingPriceTotal { get; set; }

        [Newtonsoft.Json.JsonProperty("maxMatchingPriceTotal", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? MaxMatchingPriceTotal { get; set; }

        [Newtonsoft.Json.JsonProperty("minMatchingPriceTotal", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? MinMatchingPriceTotal { get; set; }

        [Newtonsoft.Json.JsonProperty("latestMatchingPriceTotal", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? LatestMatchingPriceTotal { get; set; }

        [Newtonsoft.Json.JsonProperty("dipPriceTotal", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? DipPriceTotal { get; set; }

    }
}
