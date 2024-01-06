namespace EpiasElectricityMarketClient.Models
{
    public partial class AmountOfBlockBuyingDataDto
    {
        /// <summary>
        /// `2023-01-01T00:00:00+03:00` formatında tarih bilgisi.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("date", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? Date { get; set; }

        /// <summary>
        /// Saat Bilgisi
        /// </summary>
        [Newtonsoft.Json.JsonProperty("time", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Time { get; set; }

        /// <summary>
        /// Eşleşen Blok Alış Miktarları (MWh)
        /// </summary>
        [Newtonsoft.Json.JsonProperty("amountOfPurchasingTowardsMatchedBlock", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? AmountOfPurchasingTowardsMatchedBlock { get; set; }

        /// <summary>
        /// Eşleşmemiş Blok Alış Miktarları (MWh)
        /// </summary>
        [Newtonsoft.Json.JsonProperty("amountOfPurchasingTowardsUnMatchedBlock", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? AmountOfPurchasingTowardsUnMatchedBlock { get; set; }

    }
}
