namespace EpiasElectricityMarketClient.Models
{
    public partial class SwvResponseDataDto
    {
        /// <summary>
        /// `2023-01-01T00:00:00+03:00` formatında tarih bilgisi.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("date", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? Date { get; set; }

        /// <summary>
        /// Tedarik Yükümlülüğü Kapsamındaki UEÇM (MWh)
        /// </summary>
        [Newtonsoft.Json.JsonProperty("wqusl", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? Wqusl { get; set; }

    }
}
