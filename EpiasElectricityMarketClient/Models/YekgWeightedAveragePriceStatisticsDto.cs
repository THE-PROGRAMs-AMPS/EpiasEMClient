namespace EpiasElectricityMarketClient.Models
{
    public partial class YekgWeightedAveragePriceStatisticsDto
    {
        [Newtonsoft.Json.JsonProperty("totalAofTl", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? TotalAofTl { get; set; }

        [Newtonsoft.Json.JsonProperty("totalAofUsd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? TotalAofUsd { get; set; }

        [Newtonsoft.Json.JsonProperty("totalAofEuro", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? TotalAofEuro { get; set; }

    }
}
