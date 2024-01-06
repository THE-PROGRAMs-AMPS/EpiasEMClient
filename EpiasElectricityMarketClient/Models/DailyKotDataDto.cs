namespace EpiasElectricityMarketClient.Models
{
    public partial class DailyKotDataDto
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
        /// Günlük Kot (M)
        /// </summary>
        [Newtonsoft.Json.JsonProperty("dailyKot", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? DailyKot { get; set; }

        /// <summary>
        /// Baraj Id
        /// </summary>
        [Newtonsoft.Json.JsonProperty("damId", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public long? DamId { get; set; }

    }
}
