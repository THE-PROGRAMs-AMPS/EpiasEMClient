namespace EpiasElectricityMarketClient.Models
{
    public partial class MeterVolumeStatisticsDto
    {
        [Newtonsoft.Json.JsonProperty("cekisArtisTotal", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? CekisArtisTotal { get; set; }

        [Newtonsoft.Json.JsonProperty("cekisAzalisTotal", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? CekisAzalisTotal { get; set; }

        [Newtonsoft.Json.JsonProperty("verisArtisTotal", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? VerisArtisTotal { get; set; }

        [Newtonsoft.Json.JsonProperty("verisAzalisTotal", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? VerisAzalisTotal { get; set; }

    }
}
