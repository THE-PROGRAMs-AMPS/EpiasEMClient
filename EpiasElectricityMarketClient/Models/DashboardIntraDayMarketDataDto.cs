namespace EpiasElectricityMarketClient.Models
{
    public partial class DashboardIntraDayMarketDataDto
    {
        /// <summary>
        /// `2023-01-01T00:00:00+03:00` formatında tarih bilgisi.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("date", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? Date { get; set; }

        /// <summary>
        /// Ağırlıklı Ortalama Fiyat TL
        /// </summary>
        [Newtonsoft.Json.JsonProperty("gipAofTl", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? GipAofTl { get; set; }

        /// <summary>
        /// Eşleşme Miktarı
        /// </summary>
        [Newtonsoft.Json.JsonProperty("gipeslesmemiktar", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? Gipeslesmemiktar { get; set; }

    }
}
