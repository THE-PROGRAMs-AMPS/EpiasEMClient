namespace EpiasElectricityMarketClient.Models
{

    public partial class VepMatchingQuantityDataDto
    {
        /// <summary>
        /// `2023-01-01T00:00:00+03:00` formatında tarih bilgisi.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("date", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? Date { get; set; }

        /// <summary>
        /// Kontrat Adı
        /// </summary>
        [Newtonsoft.Json.JsonProperty("kontratAdi", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string KontratAdi { get; set; }

        /// <summary>
        /// Piyasa Eşleşme Miktarı (Lot)
        /// </summary>
        [Newtonsoft.Json.JsonProperty("marketMatchingQuantity", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? MarketMatchingQuantity { get; set; }

        /// <summary>
        /// Özel İşlem Miktarı (Lot)
        /// </summary>
        [Newtonsoft.Json.JsonProperty("privateOperationQuantity", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? PrivateOperationQuantity { get; set; }

        /// <summary>
        /// GGF İhalesi Miktarı (Lot)
        /// </summary>
        [Newtonsoft.Json.JsonProperty("dailyIndexPriceBiddingQuantity", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? DailyIndexPriceBiddingQuantity { get; set; }

        /// <summary>
        /// Baz Fiyat İhalesi Miktarı (Lot)
        /// </summary>
        [Newtonsoft.Json.JsonProperty("basePriceBiddingQuantity", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? BasePriceBiddingQuantity { get; set; }

        /// <summary>
        /// Temerrüt İhalesi Miktarı (Lot)
        /// </summary>
        [Newtonsoft.Json.JsonProperty("defaultBiddingQuantity", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? DefaultBiddingQuantity { get; set; }

        /// <summary>
        /// Sentetik Alış Eşleşme Miktarı (Lot)
        /// </summary>
        [Newtonsoft.Json.JsonProperty("syntheticBuyMatchingQuantity", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? SyntheticBuyMatchingQuantity { get; set; }

        /// <summary>
        /// Sentetik Satış Eşleşme Miktarı (Lot)
        /// </summary>
        [Newtonsoft.Json.JsonProperty("syntheticSellMatchingQuantity", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? SyntheticSellMatchingQuantity { get; set; }

        /// <summary>
        /// Toplam(MWh)
        /// </summary>
        [Newtonsoft.Json.JsonProperty("total", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? Total { get; set; }

    }


}
