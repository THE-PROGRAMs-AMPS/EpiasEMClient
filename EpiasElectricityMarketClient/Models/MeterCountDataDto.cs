namespace EpiasElectricityMarketClient.Models
{
    public partial class MeterCountDataDto
    {
        /// <summary>
        /// Talep Tahmini Yıl Verisi
        /// </summary>
        [Newtonsoft.Json.JsonProperty("date", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? Date { get; set; }

        /// <summary>
        /// 1234
        /// </summary>
        [Newtonsoft.Json.JsonProperty("meterQuantity", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public long? MeterQuantity { get; set; }

    }
}
