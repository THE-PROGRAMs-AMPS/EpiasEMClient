namespace EpiasElectricityMarketClient.Models
{
    public partial class DemandForecastDataDto
    {
        /// <summary>
        /// Talep Tahmini Yıl Verisi
        /// </summary>
        [Newtonsoft.Json.JsonProperty("year", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public long? Year { get; set; }

        /// <summary>
        /// Talep Tahmini Verileri
        /// </summary>
        [Newtonsoft.Json.JsonProperty("low", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? Low { get; set; }

        /// <summary>
        /// Talep Tahmini Verileri
        /// </summary>
        [Newtonsoft.Json.JsonProperty("base", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? Base { get; set; }

        /// <summary>
        /// Talep Tahmini Verileri
        /// </summary>
        [Newtonsoft.Json.JsonProperty("high", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? High { get; set; }

    }
}
