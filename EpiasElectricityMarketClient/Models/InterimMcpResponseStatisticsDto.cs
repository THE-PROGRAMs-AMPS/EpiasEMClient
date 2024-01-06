namespace EpiasElectricityMarketClient.Models
{

    public partial class InterimMcpResponseStatisticsDto
    {
        [Newtonsoft.Json.JsonProperty("interimMcpAvg", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? InterimMcpAvg { get; set; }

    }
}
