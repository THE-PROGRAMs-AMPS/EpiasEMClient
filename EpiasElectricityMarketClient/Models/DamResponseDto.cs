namespace EpiasElectricityMarketClient.Models
{
    public partial class DamResponseDto
    {
        /// <summary>
        /// Baraj Listesi
        /// </summary>
        [Newtonsoft.Json.JsonProperty("damList", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<string> DamList { get; set; }

    }
}
