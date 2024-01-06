namespace EpiasElectricityMarketClient.Models
{
    public partial class DailyIndexPriceDataDto
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
        /// GGF (TL/MWh)
        /// </summary>
        [Newtonsoft.Json.JsonProperty("price", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? Price { get; set; }

        /// <summary>
        /// GGF (USD/MWh)
        /// </summary>
        [Newtonsoft.Json.JsonProperty("priceUsd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? PriceUsd { get; set; }

        /// <summary>
        /// GGF (EUR/MWh)
        /// </summary>
        [Newtonsoft.Json.JsonProperty("priceEur", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? PriceEur { get; set; }

    }
}
