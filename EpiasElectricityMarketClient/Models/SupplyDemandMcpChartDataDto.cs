namespace EpiasElectricityMarketClient.Models
{
    public partial class SupplyDemandMcpChartDataDto
    {
        [Newtonsoft.Json.JsonProperty("date", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? Date { get; set; }

        [Newtonsoft.Json.JsonProperty("mcpPrice", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? McpPrice { get; set; }

        [Newtonsoft.Json.JsonProperty("matchingQuantity", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? MatchingQuantity { get; set; }

    }
}
