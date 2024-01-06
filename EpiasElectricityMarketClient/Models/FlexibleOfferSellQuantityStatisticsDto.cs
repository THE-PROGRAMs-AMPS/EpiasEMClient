namespace EpiasElectricityMarketClient.Models
{
    public partial class FlexibleOfferSellQuantityStatisticsDto
    {
        [Newtonsoft.Json.JsonProperty("totalSellingFlexibleOfferQuantityTotals", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? TotalSellingFlexibleOfferQuantityTotals { get; set; }

        [Newtonsoft.Json.JsonProperty("matchedSellingFlexibleOfferQuantityTotals", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? MatchedSellingFlexibleOfferQuantityTotals { get; set; }

        [Newtonsoft.Json.JsonProperty("unmatchedSellingFlexibleOfferQuantityTotals", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? UnmatchedSellingFlexibleOfferQuantityTotals { get; set; }

    }
}
