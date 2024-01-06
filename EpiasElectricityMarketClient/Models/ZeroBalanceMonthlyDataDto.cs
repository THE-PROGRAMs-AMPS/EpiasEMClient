namespace EpiasElectricityMarketClient.Models
{
    public partial class ZeroBalanceMonthlyDataDto
    {
        /// <summary>
        /// `2023-01-01T00:00:00+03:00` formatında tarih bilgisi.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("date", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? Date { get; set; }

        /// <summary>
        /// Toplam
        /// </summary>
        [Newtonsoft.Json.JsonProperty("zeroBalanceAdjustment", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? ZeroBalanceAdjustment { get; set; }

        /// <summary>
        /// YAT (TL)
        /// </summary>
        [Newtonsoft.Json.JsonProperty("downRegulation", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? DownRegulation { get; set; }

        /// <summary>
        /// YAL (TL)
        /// </summary>
        [Newtonsoft.Json.JsonProperty("upRegulation", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? UpRegulation { get; set; }

        /// <summary>
        /// Manuel GDDK (TL)
        /// </summary>
        [Newtonsoft.Json.JsonProperty("manual", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? Manual { get; set; }

        /// <summary>
        /// Enerji Dengesizliği Tutarı (TL)
        /// </summary>
        [Newtonsoft.Json.JsonProperty("negativeImbalance", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? NegativeImbalance { get; set; }

        /// <summary>
        /// YEK Enerji Dengesizliği Tutarı (TL)
        /// </summary>
        [Newtonsoft.Json.JsonProperty("renewableImbalance", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? RenewableImbalance { get; set; }

        /// <summary>
        /// KÜPST
        /// </summary>
        [Newtonsoft.Json.JsonProperty("kupst", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? Kupst { get; set; }

        /// <summary>
        /// YAT - 0 (TL)
        /// </summary>
        [Newtonsoft.Json.JsonProperty("downRegulationZero", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? DownRegulationZero { get; set; }

        /// <summary>
        /// YAT - 1 (TL)
        /// </summary>
        [Newtonsoft.Json.JsonProperty("downRegulationOne", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? DownRegulationOne { get; set; }

        /// <summary>
        /// YAL - 0 (TL)
        /// </summary>
        [Newtonsoft.Json.JsonProperty("upRegulationZero", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? UpRegulationZero { get; set; }

        /// <summary>
        /// YAL - 1 (TL)
        /// </summary>
        [Newtonsoft.Json.JsonProperty("upRegulationOne", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? UpRegulationOne { get; set; }

        /// <summary>
        /// YGYATT (TL)
        /// </summary>
        [Newtonsoft.Json.JsonProperty("downRegulationFine", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? DownRegulationFine { get; set; }

        /// <summary>
        /// YGYALT (TL)
        /// </summary>
        [Newtonsoft.Json.JsonProperty("upRegulationFine", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? UpRegulationFine { get; set; }

    }


}
