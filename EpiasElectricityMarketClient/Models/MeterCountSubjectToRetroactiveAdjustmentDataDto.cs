namespace EpiasElectricityMarketClient.Models
{

    public partial class MeterCountSubjectToRetroactiveAdjustmentDataDto
    {
        /// <summary>
        /// `2023-01-01T00:00:00+03:00` formatında tarih bilgisi.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("period", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? Period { get; set; }

        /// <summary>
        /// Toplam
        /// </summary>
        [Newtonsoft.Json.JsonProperty("total", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? Total { get; set; }

        /// <summary>
        /// Üç Zamanlı Sayaç Sayısı
        /// </summary>
        [Newtonsoft.Json.JsonProperty("threeTimedMeterCount", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? ThreeTimedMeterCount { get; set; }

        /// <summary>
        /// Tek Zamanlı Sayaç Sayısı
        /// </summary>
        [Newtonsoft.Json.JsonProperty("singleTimedMeterCount", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? SingleTimedMeterCount { get; set; }

        /// <summary>
        /// Saatlik Sayaç Sayısı
        /// </summary>
        [Newtonsoft.Json.JsonProperty("hourlyTimedMeterCount", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? HourlyTimedMeterCount { get; set; }

    }

}
