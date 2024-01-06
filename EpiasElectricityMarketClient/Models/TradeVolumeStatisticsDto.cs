namespace EpiasElectricityMarketClient.Models
{
    public partial class TradeVolumeStatisticsDto
    {
        [Newtonsoft.Json.JsonProperty("volumeTotal", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? VolumeTotal { get; set; }

        [Newtonsoft.Json.JsonProperty("ozelIslemBildirimHacmiTotal", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? OzelIslemBildirimHacmiTotal { get; set; }

        [Newtonsoft.Json.JsonProperty("totalSum", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? TotalSum { get; set; }

    }
}
