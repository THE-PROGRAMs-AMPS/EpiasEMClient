namespace EpiasElectricityMarketClient.Models
{
    public partial class IntraDayDashboardMatchResponseDto
    {
        [Newtonsoft.Json.JsonProperty("items", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<DashboardIntraDayMarketDataDto> Items { get; set; }

        /// <summary>
        /// Son güncelleme zamanı bilgisi(`2023-01-01T00:00:00+03:00` formatında).
        /// </summary>
        [Newtonsoft.Json.JsonProperty("latestUpdateTime", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? LatestUpdateTime { get; set; }

    }
}
