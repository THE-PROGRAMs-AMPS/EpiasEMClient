namespace EpiasElectricityMarketClient.Models
{
    public partial class MatchedFlexibleOfferQuantityDataDto
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
        /// Esnek Alış Teklif Eşleşme Miktarı (MWh)
        /// </summary>
        [Newtonsoft.Json.JsonProperty("matchedFlexibleBuyingOfferQuantity", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? MatchedFlexibleBuyingOfferQuantity { get; set; }

        /// <summary>
        /// Esnek Satış Teklif Eşleşme Miktarı (MWh)
        /// </summary>
        [Newtonsoft.Json.JsonProperty("matchedFlexibleSellingOfferQuantity", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? MatchedFlexibleSellingOfferQuantity { get; set; }

    }
}
