namespace EpiasElectricityMarketClient.Models
{
    public partial class FlexibleOfferSellQuantityDataDto
    {
        /// <summary>
        /// `2023-01-01T00:00:00+03:00` formatında tarih bilgisi.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("date", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? Date { get; set; }

        /// <summary>
        /// Toplam Esnek Satış Teklif Miktarı (Mwh)
        /// </summary>
        [Newtonsoft.Json.JsonProperty("totalSellingFlexibleOfferQuantity", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? TotalSellingFlexibleOfferQuantity { get; set; }

        /// <summary>
        /// Eşleşen Esnek Satış Teklif Miktarı (Mwh)
        /// </summary>
        [Newtonsoft.Json.JsonProperty("matchedSellingFlexibleOfferQuantity", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? MatchedSellingFlexibleOfferQuantity { get; set; }

        /// <summary>
        /// Eşleşmeyen Esnek Satış Teklif Miktarı (Mwh)
        /// </summary>
        [Newtonsoft.Json.JsonProperty("unmatchedSellingFlexibleOfferQuantity", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? UnmatchedSellingFlexibleOfferQuantity { get; set; }

    }
}
