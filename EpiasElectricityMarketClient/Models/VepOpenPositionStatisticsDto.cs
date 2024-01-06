namespace EpiasElectricityMarketClient.Models
{
    public partial class VepOpenPositionStatisticsDto
    {
        [Newtonsoft.Json.JsonProperty("openPositionTotal", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? OpenPositionTotal { get; set; }

    }
}
