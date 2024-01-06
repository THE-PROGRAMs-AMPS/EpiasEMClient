namespace EpiasElectricityMarketClient.Models
{
    public partial class YekgOrderQuantityDataDto
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
        [Newtonsoft.Json.JsonProperty("alisTeklifMiktari", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? AlisTeklifMiktari { get; set; }

        /// <summary>
        /// Min. Eşleşme Fiyatı (TL/MWh)
        /// </summary>
        [Newtonsoft.Json.JsonProperty("satisTeklifMiktari", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? SatisTeklifMiktari { get; set; }

    }
}
