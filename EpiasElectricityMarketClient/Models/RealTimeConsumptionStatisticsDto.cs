namespace EpiasElectricityMarketClient.Models
{
    public partial class RealTimeConsumptionStatisticsDto
    {
        [Newtonsoft.Json.JsonProperty("consumptionTotal", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? ConsumptionTotal { get; set; }

        [Newtonsoft.Json.JsonProperty("consumptionAvg", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? ConsumptionAvg { get; set; }

        [Newtonsoft.Json.JsonProperty("consumptionMin", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? ConsumptionMin { get; set; }

        [Newtonsoft.Json.JsonProperty("consumptionMax", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? ConsumptionMax { get; set; }

    }

}
