namespace EpiasElectricityMarketClient.Models
{
    public partial class InstalledCapacityOldDto
    {
        /// <summary>
        /// Kaynak
        /// </summary>
        [Newtonsoft.Json.JsonProperty("resourceType", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ResourceType { get; set; }

        /// <summary>
        /// Toplam
        /// </summary>
        [Newtonsoft.Json.JsonProperty("total", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? Total { get; set; }

    }
}
