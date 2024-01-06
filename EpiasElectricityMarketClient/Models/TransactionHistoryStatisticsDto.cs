namespace EpiasElectricityMarketClient.Models
{
    public partial class TransactionHistoryStatisticsDto
    {
        [Newtonsoft.Json.JsonProperty("matchingPriceTotal", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? MatchingPriceTotal { get; set; }

        [Newtonsoft.Json.JsonProperty("matchingQuantityTotal", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? MatchingQuantityTotal { get; set; }

        [Newtonsoft.Json.JsonProperty("totalSum", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? TotalSum { get; set; }

    }
}
