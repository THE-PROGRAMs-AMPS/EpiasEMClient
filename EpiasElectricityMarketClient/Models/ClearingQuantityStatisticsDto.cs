namespace EpiasElectricityMarketClient.Models
{
    public partial class ClearingQuantityStatisticsDto
    {
        [Newtonsoft.Json.JsonProperty("matchedBidsTotal", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? MatchedBidsTotal { get; set; }

        [Newtonsoft.Json.JsonProperty("matchedOfferTotal", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? MatchedOfferTotal { get; set; }

    }
}
