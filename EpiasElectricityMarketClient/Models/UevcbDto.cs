namespace EpiasElectricityMarketClient.Models
{

    public partial class UevcbDto
    {
        /// <summary>
        /// UEVÇB Id bilgisi(bkz.Uevçb Listeleme Servisi)
        /// </summary>
        [Newtonsoft.Json.JsonProperty("id", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public long? Id { get; set; }

        /// <summary>
        /// UEVÇB Adı
        /// </summary>
        [Newtonsoft.Json.JsonProperty("name", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// UEVÇB EIC(ETSO) kodu
        /// </summary>
        [Newtonsoft.Json.JsonProperty("eic", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Eic { get; set; }

    }
}
