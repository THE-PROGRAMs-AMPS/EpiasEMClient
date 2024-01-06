namespace EpiasElectricityMarketClient.Models
{
    public partial class PtfResponseDataDto
    {
        /// <summary>
        /// `2023-01-01T00:00:00+03:00` formatında tarih bilgisi.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("date", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? Date { get; set; }

        /// <summary>
        /// Saat Bilgisi
        /// </summary>
        [Newtonsoft.Json.JsonProperty("hour", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Hour { get; set; }

        /// <summary>
        /// TL cinsinden PTF bilgisi (TL/MWh).
        /// </summary>
        [Newtonsoft.Json.JsonProperty("price", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? Price { get; set; }

        /// <summary>
        /// USD cinsinden PTF bilgisi (USD/MWh).
        /// </summary>
        [Newtonsoft.Json.JsonProperty("priceUsd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? PriceUsd { get; set; }

        /// <summary>
        /// EUR cinsinden PTF bilgisi (EUR/MWh).
        /// </summary>
        [Newtonsoft.Json.JsonProperty("priceEur", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? PriceEur { get; set; }

    }
}
