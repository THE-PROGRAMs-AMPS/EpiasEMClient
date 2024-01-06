namespace EpiasElectricityMarketClient.Models
{
    public partial class DashboardBalancingPowerMarketDataDto
    {
        /// <summary>
        /// `2023-01-01T00:00:00+03:00` formatında tarih bilgisi.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("date", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? Date { get; set; }

        /// <summary>
        /// Sistem Marjinal Fiyatı Listeleme Servisi
        /// </summary>
        [Newtonsoft.Json.JsonProperty("smf", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? Smf { get; set; }

        /// <summary>
        /// Yük Alma (YAL) Talimat Miktarları Listeleme Servisi
        /// </summary>
        [Newtonsoft.Json.JsonProperty("yal", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? Yal { get; set; }

        /// <summary>
        /// Yük Atma (YAT) Talimat Miktarı Listeleme Servisi
        /// </summary>
        [Newtonsoft.Json.JsonProperty("yat", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? Yat { get; set; }

    }
}
