namespace EpiasElectricityMarketClient.Models
{
    public partial class OrderSummaryUpDataDto
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
        /// YAL (0) (MWh)
        /// </summary>
        [Newtonsoft.Json.JsonProperty("upRegulationZeroCoded", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? UpRegulationZeroCoded { get; set; }

        /// <summary>
        /// YAL (1) (MWh)
        /// </summary>
        [Newtonsoft.Json.JsonProperty("upRegulationOneCoded", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? UpRegulationOneCoded { get; set; }

        /// <summary>
        /// YAL (2) (MWh)
        /// </summary>
        [Newtonsoft.Json.JsonProperty("upRegulationTwoCoded", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? UpRegulationTwoCoded { get; set; }

        /// <summary>
        /// İlgili saatte verilmiş teslim edilmiş toplam yal talimat miktar bilgisidir.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("upRegulationDelivered", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? UpRegulationDelivered { get; set; }

        /// <summary>
        /// İlgili saatte verilmiş net talimat miktar bilgisidir.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("net", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? Net { get; set; }

    }


}
