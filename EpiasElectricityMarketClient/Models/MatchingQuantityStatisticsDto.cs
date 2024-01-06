namespace EpiasElectricityMarketClient.Models
{
    public partial class MatchingQuantityStatisticsDto
    {
        [Newtonsoft.Json.JsonProperty("clearingQuantityTotal", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? ClearingQuantityTotal { get; set; }

    }
}
