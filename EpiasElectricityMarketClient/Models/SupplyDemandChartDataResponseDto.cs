namespace EpiasElectricityMarketClient.Models
{
    public partial class SupplyDemandChartDataResponseDto
    {
        [Newtonsoft.Json.JsonProperty("items", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<SupplyDemandChartDataDto> Items { get; set; }

    }
}
