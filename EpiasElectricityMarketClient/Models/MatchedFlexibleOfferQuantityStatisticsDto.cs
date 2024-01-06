namespace EpiasElectricityMarketClient.Models
{

    public partial class MatchedFlexibleOfferQuantityStatisticsDto
    {
        [Newtonsoft.Json.JsonProperty("matchingFlexDemandTotals", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? MatchingFlexDemandTotals { get; set; }

        [Newtonsoft.Json.JsonProperty("matchingFlexSupplyTotals", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? MatchingFlexSupplyTotals { get; set; }

    }
}
