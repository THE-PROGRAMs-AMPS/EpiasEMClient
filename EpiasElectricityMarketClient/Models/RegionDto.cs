namespace EpiasElectricityMarketClient.Models
{
    public partial class RegionDto
    {
        /// <summary>
        /// Bölge id değeri
        /// </summary>
        [Newtonsoft.Json.JsonProperty("regionId", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public long? RegionId { get; set; }

        /// <summary>
        /// Bölge kısa adı
        /// </summary>
        [Newtonsoft.Json.JsonProperty("regionShortName", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string RegionShortName { get; set; }

    }
}
