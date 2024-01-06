namespace EpiasElectricityMarketClient.Models
{
    public partial class FlexibleOfferBuyQuantityStatisticsDto
    {
        [Newtonsoft.Json.JsonProperty("totalBuyingFlexibleOfferQuantityTotals", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? TotalBuyingFlexibleOfferQuantityTotals { get; set; }

        [Newtonsoft.Json.JsonProperty("matchedBuyingFlexibleOfferQuantityTotals", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? MatchedBuyingFlexibleOfferQuantityTotals { get; set; }

        [Newtonsoft.Json.JsonProperty("unmatchedBuyingFlexibleOfferQuantityTotals", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? UnmatchedBuyingFlexibleOfferQuantityTotals { get; set; }

    }

}
