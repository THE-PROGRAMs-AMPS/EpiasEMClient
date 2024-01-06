namespace EpiasElectricityMarketClient.Models
{

    public partial class ActiveFullnessDataDto
    {
        /// <summary>
        /// `2023-01-01T00:00:00+03:00` formatında tarih bilgisi.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("date", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? Date { get; set; }

        /// <summary>
        /// Yön
        /// </summary>
        [Newtonsoft.Json.JsonProperty("basin", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Basin { get; set; }

        /// <summary>
        /// Yön
        /// </summary>
        [Newtonsoft.Json.JsonProperty("dam", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Dam { get; set; }

        /// <summary>
        /// Aktif Doluluk (%)
        /// </summary>
        [Newtonsoft.Json.JsonProperty("activeFullnessAmount", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? ActiveFullnessAmount { get; set; }

        /// <summary>
        /// Id
        /// </summary>
        [Newtonsoft.Json.JsonProperty("id", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? Id { get; set; }

    }

}
