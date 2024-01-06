namespace EpiasElectricityMarketClient.Models
{
    public partial class OrderSummaryDownDataDto
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
        /// YAT (0) (MWh)
        /// </summary>
        [Newtonsoft.Json.JsonProperty("downRegulationZeroCoded", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? DownRegulationZeroCoded { get; set; }

        /// <summary>
        /// YAT (1) (MWh)
        /// </summary>
        [Newtonsoft.Json.JsonProperty("downRegulationOneCoded", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? DownRegulationOneCoded { get; set; }

        /// <summary>
        /// YAT (2) (MWh)
        /// </summary>
        [Newtonsoft.Json.JsonProperty("downRegulationTwoCoded", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? DownRegulationTwoCoded { get; set; }

        /// <summary>
        /// İlgili saatte verilmiş teslim edilmiş toplam yat talimat miktar bilgisidir.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("downRegulationDelivered", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? DownRegulationDelivered { get; set; }

        /// <summary>
        /// İlgili saatte verilmiş net talimat miktar bilgisidir.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("net", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? Net { get; set; }

    }

}
