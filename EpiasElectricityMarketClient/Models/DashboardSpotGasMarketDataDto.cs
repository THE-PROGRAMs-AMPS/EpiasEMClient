namespace EpiasElectricityMarketClient.Models
{
    public partial class DashboardSpotGasMarketDataDto
    {
        /// <summary>
        /// `2023-01-01T00:00:00+03:00` formatında tarih bilgisi.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("date", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? Date { get; set; }

        /// <summary>
        /// GRF (TL/1000Sm3)
        /// </summary>
        [Newtonsoft.Json.JsonProperty("grfTl", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? GrfTl { get; set; }

        /// <summary>
        /// GRF (USD/1000Sm3)
        /// </summary>
        [Newtonsoft.Json.JsonProperty("grfUsd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? GrfUsd { get; set; }

        /// <summary>
        /// GRF (EUR/1000Sm3)
        /// </summary>
        [Newtonsoft.Json.JsonProperty("grfEur", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? GrfEur { get; set; }

        /// <summary>
        /// GRF (USD/MMBtu)
        /// </summary>
        [Newtonsoft.Json.JsonProperty("grfUsdMmBtu", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? GrfUsdMmBtu { get; set; }

        /// <summary>
        /// GRF Eşleşme Miktarı
        /// </summary>
        [Newtonsoft.Json.JsonProperty("matchQuantityAmount", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? MatchQuantityAmount { get; set; }

    }

}
