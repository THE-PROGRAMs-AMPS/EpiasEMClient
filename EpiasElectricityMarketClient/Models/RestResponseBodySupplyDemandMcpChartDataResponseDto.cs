namespace EpiasElectricityMarketClient.Models
{
    public partial class RestResponseBodySupplyDemandMcpChartDataResponseDto
    {
        [Newtonsoft.Json.JsonProperty("content", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public SupplyDemandMcpChartDataResponseDto Content { get; set; }

    }

}
