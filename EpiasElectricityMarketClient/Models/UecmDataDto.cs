namespace EpiasElectricityMarketClient.Models
{
    public partial class UecmDataDto
    {
        /// <summary>
        /// Dönem
        /// </summary>
        [Newtonsoft.Json.JsonProperty("period", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? Period { get; set; }

        /// <summary>
        /// Saat Bilgisi
        /// </summary>
        [Newtonsoft.Json.JsonProperty("hour", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? Hour { get; set; }

        /// <summary>
        /// Serbest Tüketici Hakkını Kullananların Çekiş Miktarı (MWh)
        /// </summary>
        [Newtonsoft.Json.JsonProperty("swv", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? Swv { get; set; }

    }
}
