namespace EpiasElectricityMarketClient.Models
{
    public partial class CongestionCostDataDto
    {
        /// <summary>
        /// şehir
        /// </summary>
        [Newtonsoft.Json.JsonProperty("cityName", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string CityName { get; set; }

        /// <summary>
        /// Kısıt Maliyeti
        /// </summary>
        [Newtonsoft.Json.JsonProperty("congestionCost", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? CongestionCost { get; set; }

    }
}
