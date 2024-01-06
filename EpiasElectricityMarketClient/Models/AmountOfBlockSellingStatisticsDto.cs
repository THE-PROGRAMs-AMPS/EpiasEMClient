namespace EpiasElectricityMarketClient.Models
{
    public partial class AmountOfBlockSellingStatisticsDto
    {
        [Newtonsoft.Json.JsonProperty("amountOfSalesTowardsMatchedBlockTotals", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? AmountOfSalesTowardsMatchedBlockTotals { get; set; }

        [Newtonsoft.Json.JsonProperty("amountOfSalesTowardsUnMatchedBlockTotals", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? AmountOfSalesTowardsUnMatchedBlockTotals { get; set; }

    }
}
