namespace EpiasElectricityMarketClient.Models
{
    public partial class YekgMinMaxMatchAmountDataDto
    {
        /// <summary>
        /// `2023-01-01T00:00:00+03:00` formatında tarih bilgisi.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("date", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? Date { get; set; }

        /// <summary>
        /// Kaynak Tipi
        /// </summary>
        [Newtonsoft.Json.JsonProperty("resourceType", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ResourceType { get; set; }

        /// <summary>
        /// Max. Eşleşme Fiyatı (TL/MWh)
        /// </summary>
        [Newtonsoft.Json.JsonProperty("minMatchPrice", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? MinMatchPrice { get; set; }

        /// <summary>
        /// Min. Eşleşme Fiyatı (TL/MWh)
        /// </summary>
        [Newtonsoft.Json.JsonProperty("maxMatchPrice", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? MaxMatchPrice { get; set; }

    }
}
