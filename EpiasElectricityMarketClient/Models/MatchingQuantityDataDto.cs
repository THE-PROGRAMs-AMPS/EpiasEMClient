namespace EpiasElectricityMarketClient.Models
{
    public partial class MatchingQuantityDataDto
    {
        /// <summary>
        /// Kontrat Türü;
        /// </summary>
        [Newtonsoft.Json.JsonProperty("kontratTuru", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string KontratTuru { get; set; }

        /// <summary>
        /// Kontrat Adı;
        /// </summary>
        [Newtonsoft.Json.JsonProperty("kontratAdi", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string KontratAdi { get; set; }

        /// <summary>
        /// Eşleşme Miktarı (MWh);
        /// </summary>
        [Newtonsoft.Json.JsonProperty("clearingQuantity", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? ClearingQuantity { get; set; }

    }
}
