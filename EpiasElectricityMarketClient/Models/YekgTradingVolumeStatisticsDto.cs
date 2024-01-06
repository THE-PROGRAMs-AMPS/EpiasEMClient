namespace EpiasElectricityMarketClient.Models
{
    public partial class YekgTradingVolumeStatisticsDto
    {
        [Newtonsoft.Json.JsonProperty("totalVolumeTl", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? TotalVolumeTl { get; set; }

        [Newtonsoft.Json.JsonProperty("totalVolumeUsd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? TotalVolumeUsd { get; set; }

        [Newtonsoft.Json.JsonProperty("totalVolumeEuro", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? TotalVolumeEuro { get; set; }

    }
}
