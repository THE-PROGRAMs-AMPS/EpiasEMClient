namespace EpiasElectricityMarketClient.Models
{
    public partial class ContractPriceSummaryDataDto
    {
        /// <summary>
        /// `2023-01-01T00:00:00+03:00` formatında tarih bilgisi.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("date", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? Date { get; set; }

        /// <summary>
        /// Kontrat Adı
        /// </summary>
        [Newtonsoft.Json.JsonProperty("contractName", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ContractName { get; set; }

        /// <summary>
        /// İlk Eşleşme Fiyatı (TL/MWh)
        /// </summary>
        [Newtonsoft.Json.JsonProperty("firstMatchingPrice", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? FirstMatchingPrice { get; set; }

        /// <summary>
        /// En Yüksek Eşleşme Fiyatı (TL/MWh)
        /// </summary>
        [Newtonsoft.Json.JsonProperty("maxMatchingPrice", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? MaxMatchingPrice { get; set; }

        /// <summary>
        /// En Düşük Eşleşme Fiyatı (TL/MWh)
        /// </summary>
        [Newtonsoft.Json.JsonProperty("minMatchingPrice", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? MinMatchingPrice { get; set; }

        /// <summary>
        /// Son Eşleşme Fiyatı (TL/MWh)
        /// </summary>
        [Newtonsoft.Json.JsonProperty("latestMatchingPrice", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? LatestMatchingPrice { get; set; }

        /// <summary>
        /// GGF (TL/MWh)
        /// </summary>
        [Newtonsoft.Json.JsonProperty("dipPrice", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? DipPrice { get; set; }

    }

}
