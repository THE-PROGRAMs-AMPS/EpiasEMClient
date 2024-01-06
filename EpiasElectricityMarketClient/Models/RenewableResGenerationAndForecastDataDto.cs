namespace EpiasElectricityMarketClient.Models
{


    public partial class RenewableResGenerationAndForecastDataDto
    {
        /// <summary>
        /// `2023-01-01T00:00:00+03:00` formatında tarih bilgisi.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("date", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? Date { get; set; }

        /// <summary>
        /// `2023-01-01T00:00:00+03:00` formatında tarih bilgisi.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("time", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? Time { get; set; }

        /// <summary>
        /// Q5
        /// </summary>
        [Newtonsoft.Json.JsonProperty("quarter1", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? Quarter1 { get; set; }

        /// <summary>
        /// Q25
        /// </summary>
        [Newtonsoft.Json.JsonProperty("quarter2", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? Quarter2 { get; set; }

        /// <summary>
        /// Q75
        /// </summary>
        [Newtonsoft.Json.JsonProperty("quarter3", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? Quarter3 { get; set; }

        /// <summary>
        /// Q95
        /// </summary>
        [Newtonsoft.Json.JsonProperty("quarter4", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? Quarter4 { get; set; }

        /// <summary>
        /// Üretim(MW)
        /// </summary>
        [Newtonsoft.Json.JsonProperty("generation", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? Generation { get; set; }

        /// <summary>
        /// Tahmin(MW)
        /// </summary>
        [Newtonsoft.Json.JsonProperty("forecast", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? Forecast { get; set; }

    }

}
