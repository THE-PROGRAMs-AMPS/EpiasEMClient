namespace EpiasElectricityMarketClient.Models
{
    public partial class SidePaymentDataDto
    {
        /// <summary>
        /// `2023-01-01T00:00:00+03:00` formatında tarih bilgisi.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("date", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? Date { get; set; }

        /// <summary>
        /// Alış Tekliflerinden Kaynaklı (TL)
        /// </summary>
        [Newtonsoft.Json.JsonProperty("originatingFromBids", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? OriginatingFromBids { get; set; }

        /// <summary>
        /// Satış Tekliflerinden Kaynaklı (TL)
        /// </summary>
        [Newtonsoft.Json.JsonProperty("originatingFromOffers", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? OriginatingFromOffers { get; set; }

        /// <summary>
        /// Yuvarlama Kaynaklı (TL)
        /// </summary>
        [Newtonsoft.Json.JsonProperty("originatingFromRounding", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? OriginatingFromRounding { get; set; }

        /// <summary>
        /// Toplam
        /// </summary>
        [Newtonsoft.Json.JsonProperty("total", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? Total { get; set; }

    }
}
