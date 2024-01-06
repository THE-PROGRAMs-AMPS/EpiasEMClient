namespace EpiasElectricityMarketClient.Models
{
    public partial class FlexibleOfferBuyQuantityDataDto
    {
        /// <summary>
        /// `2023-01-01T00:00:00+03:00` formatında tarih bilgisi.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("date", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? Date { get; set; }

        /// <summary>
        /// Toplam Esnek Alış Teklif Miktarı (Mwh)
        /// </summary>
        [Newtonsoft.Json.JsonProperty("totalBuyingFlexibleOfferQuantity", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? TotalBuyingFlexibleOfferQuantity { get; set; }

        /// <summary>
        /// Eşleşen Esnek Alış Teklif Miktarı (Mwh)
        /// </summary>
        [Newtonsoft.Json.JsonProperty("matchedBuyingFlexibleOfferQuantity", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? MatchedBuyingFlexibleOfferQuantity { get; set; }

        /// <summary>
        /// Eşleşmeyen Esnek Alış Teklif Miktarı (Mwh)
        /// </summary>
        [Newtonsoft.Json.JsonProperty("unmatchedBuyingFlexibleOfferQuantity", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? UnmatchedBuyingFlexibleOfferQuantity { get; set; }

    }
}
