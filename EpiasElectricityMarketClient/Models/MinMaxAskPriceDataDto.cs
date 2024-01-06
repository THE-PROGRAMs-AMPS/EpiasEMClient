namespace EpiasElectricityMarketClient.Models
{
    public partial class MinMaxAskPriceDataDto
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
        /// Min. Satış Fiyatı (TL/MWh)
        /// </summary>
        [Newtonsoft.Json.JsonProperty("minAskPrice", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? MinAskPrice { get; set; }

        /// <summary>
        /// Max. Satış Fiyatı (TL/MWh)
        /// </summary>
        [Newtonsoft.Json.JsonProperty("maxAskPrice", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? MaxAskPrice { get; set; }

    }
}
