namespace EpiasElectricityMarketClient.Models
{
    public partial class DayAheadMarketTradeVolumeStatisticsDto
    {
        [Newtonsoft.Json.JsonProperty("volumeOfAskTotal", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? VolumeOfAskTotal { get; set; }

    }
}
