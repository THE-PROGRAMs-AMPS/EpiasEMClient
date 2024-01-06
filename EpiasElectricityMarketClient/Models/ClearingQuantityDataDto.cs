namespace EpiasElectricityMarketClient.Models
{
    public partial class ClearingQuantityDataDto
    {
        /// <summary>
        /// `2023-01-01T00:00:00+03:00` formatında tarih bilgisi.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("date", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? Date { get; set; }

        /// <summary>
        /// Saat Bilgisi
        /// </summary>
        [Newtonsoft.Json.JsonProperty("hour", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Hour { get; set; }

        /// <summary>
        /// Eşleşen Alış Miktarı
        /// </summary>
        [Newtonsoft.Json.JsonProperty("matchedBids", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? MatchedBids { get; set; }

        /// <summary>
        /// Eşleşen Satış Miktarı
        /// </summary>
        [Newtonsoft.Json.JsonProperty("matchedOffers", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? MatchedOffers { get; set; }

    }
}
