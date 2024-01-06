namespace EpiasElectricityMarketClient.Models
{
    public partial class MinMaxMatchingPriceDataDto
    {
        /// <summary>
        /// Kontrat Türü;
        /// </summary>
        [Newtonsoft.Json.JsonProperty("contractType", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ContractType { get; set; }

        /// <summary>
        /// Kontrat Adı;
        /// </summary>
        [Newtonsoft.Json.JsonProperty("contractName", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ContractName { get; set; }

        /// <summary>
        /// En Düşük Eşleşme Fiyatı (TL/MWh)
        /// </summary>
        [Newtonsoft.Json.JsonProperty("minMatchingPrice", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? MinMatchingPrice { get; set; }

        /// <summary>
        /// En Yüksek Eşleşme Fiyatı (TL/MWh)
        /// </summary>
        [Newtonsoft.Json.JsonProperty("maxMatchingPrice", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? MaxMatchingPrice { get; set; }

    }
}
