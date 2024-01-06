namespace EpiasElectricityMarketClient.Models
{
    public partial class AmountOfBlockBuyingStatisticsDto
    {
        [Newtonsoft.Json.JsonProperty("amountOfPurchasingTowardsMatchedBlockTotals", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? AmountOfPurchasingTowardsMatchedBlockTotals { get; set; }

        [Newtonsoft.Json.JsonProperty("amountOfPurchasingTowardsUnMatchedBlockTotals", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? AmountOfPurchasingTowardsUnMatchedBlockTotals { get; set; }

    }
}
