namespace EpiasElectricityMarketClient.Models
{
    public partial class InterconnectionLineCapacitiesDataDto
    {
        /// <summary>
        /// Transfer Zamanı
        /// </summary>
        [Newtonsoft.Json.JsonProperty("date", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? Date { get; set; }

        /// <summary>
        /// `2023-01-01T00:00:00+03:00` formatında tarih bilgisi.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("time", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? Time { get; set; }

        /// <summary>
        /// Yön
        /// </summary>
        [Newtonsoft.Json.JsonProperty("direction", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Direction { get; set; }

        /// <summary>
        /// Toplam Kapasite(MW)
        /// </summary>
        [Newtonsoft.Json.JsonProperty("totalCapacity", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? TotalCapacity { get; set; }

        /// <summary>
        /// Toplam Kapasite(MW)
        /// </summary>
        [Newtonsoft.Json.JsonProperty("availableCapacity", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? AvailableCapacity { get; set; }

    }
}
