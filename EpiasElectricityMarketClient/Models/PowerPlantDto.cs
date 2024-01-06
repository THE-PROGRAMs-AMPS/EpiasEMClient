namespace EpiasElectricityMarketClient.Models
{
    public partial class PowerPlantDto
    {
        /// <summary>
        /// Santral id değeri
        /// </summary>
        [Newtonsoft.Json.JsonProperty("id", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public long? Id { get; set; }

        /// <summary>
        /// Santral adı
        /// </summary>
        [Newtonsoft.Json.JsonProperty("name", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// Santral  EIC(ETSO) kodu
        /// </summary>
        [Newtonsoft.Json.JsonProperty("eic", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Eic { get; set; }

        /// <summary>
        /// Santral kısa adı
        /// </summary>
        [Newtonsoft.Json.JsonProperty("shortName", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ShortName { get; set; }

    }
}
