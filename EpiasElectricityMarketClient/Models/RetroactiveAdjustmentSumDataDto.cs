namespace EpiasElectricityMarketClient.Models
{


    public partial class RetroactiveAdjustmentSumDataDto
    {
        /// <summary>
        /// `2023-01-01T00:00:00+03:00` formatında tarih bilgisi.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("period", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? Period { get; set; }

        /// <summary>
        /// `2023-01-01T00:00:00+03:00` formatında tarih bilgisi.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("version", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? Version { get; set; }

        /// <summary>
        /// Alacak GDDK Tutarı (TL)
        /// </summary>
        [Newtonsoft.Json.JsonProperty("gddkCreditAmount", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? GddkCreditAmount { get; set; }

        /// <summary>
        /// Borç GDDK Tutarı (TL)
        /// </summary>
        [Newtonsoft.Json.JsonProperty("gddkDebtAmount", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? GddkDebtAmount { get; set; }

        /// <summary>
        /// Net GDDK Tutarı (TL)
        /// </summary>
        [Newtonsoft.Json.JsonProperty("gddkNetAmount", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? GddkNetAmount { get; set; }

    }

}
