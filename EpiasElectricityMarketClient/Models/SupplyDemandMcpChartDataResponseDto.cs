namespace EpiasElectricityMarketClient.Models
{
    public partial class SupplyDemandMcpChartDataResponseDto
    {
        [Newtonsoft.Json.JsonProperty("response", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public SupplyDemandMcpChartDataDto Response { get; set; }

    }
}
