namespace EpiasElectricityMarketClient.Models
{


    public partial class TransactionHistoryDataDto
    {
        /// <summary>
        /// `2023-01-01T00:00:00+03:00` formatında tarih bilgisi.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("date", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public DateTimeOffset? Date { get; set; }

        /// <summary>
        /// Saat Bilgisi
        /// </summary>
        [Newtonsoft.Json.JsonProperty("matchTime", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string MatchTime { get; set; }

        /// <summary>
        /// Kontrat Adı
        /// </summary>
        [Newtonsoft.Json.JsonProperty("contractName", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ContractName { get; set; }

        /// <summary>
        /// İşlem Tipi
        /// </summary>
        [Newtonsoft.Json.JsonProperty("transactionType", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string TransactionType { get; set; }

        /// <summary>
        /// Eşleşme Fiyatı (TL/MWh)
        /// </summary>
        [Newtonsoft.Json.JsonProperty("matchingPrice", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? MatchingPrice { get; set; }

        /// <summary>
        /// Eşleşme Miktarı (Lot)
        /// </summary>
        [Newtonsoft.Json.JsonProperty("matchingQuantity", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? MatchingQuantity { get; set; }

        /// <summary>
        /// Toplam(MWh)
        /// </summary>
        [Newtonsoft.Json.JsonProperty("total", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? Total { get; set; }

    }

}
