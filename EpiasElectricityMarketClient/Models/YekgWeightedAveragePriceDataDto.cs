namespace EpiasElectricityMarketClient.Models
{
    public partial class YekgWeightedAveragePriceDataDto
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
        /// Ağırlıklı Ortalama Fiyat (TL/MWh)
        /// </summary>
        [Newtonsoft.Json.JsonProperty("aofTl", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? AofTl { get; set; }

        /// <summary>
        /// Ağırlıklı Ortalama Fiyat (USD/MWh)
        /// </summary>
        [Newtonsoft.Json.JsonProperty("aofUsd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? AofUsd { get; set; }

        /// <summary>
        /// Ağırlıklı Ortalama Fiyat (EUR/MWh)
        /// </summary>
        [Newtonsoft.Json.JsonProperty("aofEuro", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? AofEuro { get; set; }

    }
}
