namespace EpiasElectricityMarketClient.Models
{
    public partial class SupplyDemandDataDto
    {
        /// <summary>
        /// `2023-01-01T00:00:00+03:00` formatında tarih bilgisi.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("date", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? Date { get; set; }

        /// <summary>
        /// Fiyat(TL/MWh)
        /// </summary>
        [Newtonsoft.Json.JsonProperty("price", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? Price { get; set; }

        /// <summary>
        /// Arz(MWh)
        /// </summary>
        [Newtonsoft.Json.JsonProperty("supply", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? Supply { get; set; }

        /// <summary>
        /// Talep(MWh)
        /// </summary>
        [Newtonsoft.Json.JsonProperty("demand", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? Demand { get; set; }

    }
}
