namespace EpiasElectricityMarketClient.Models
{
    public partial class SupplyDemandChartDataDto
    {
        /// <summary>
        /// Miktar
        /// </summary>
        [Newtonsoft.Json.JsonProperty("amount", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? Amount { get; set; }

        /// <summary>
        /// Arz Fiyatı
        /// </summary>
        [Newtonsoft.Json.JsonProperty("supplyPrice", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? SupplyPrice { get; set; }

        /// <summary>
        /// Talep Fiyatı
        /// </summary>
        [Newtonsoft.Json.JsonProperty("demandPrice", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? DemandPrice { get; set; }

    }
}
