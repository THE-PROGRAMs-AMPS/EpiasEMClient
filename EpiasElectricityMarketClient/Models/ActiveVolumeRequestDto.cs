namespace EpiasElectricityMarketClient.Models
{
    public partial class ActiveVolumeRequestDto
    {
        /// <summary>
        /// Havza
        /// </summary>
        [Newtonsoft.Json.JsonProperty("basinName", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string BasinName { get; set; }

        /// <summary>
        /// Baraj
        /// </summary>
        [Newtonsoft.Json.JsonProperty("damName", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string DamName { get; set; }

        /// <summary>
        /// Sayfalama bilgisi.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("page", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Page Page { get; set; }

    }
}
