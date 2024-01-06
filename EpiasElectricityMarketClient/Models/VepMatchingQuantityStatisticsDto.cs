namespace EpiasElectricityMarketClient.Models
{
    public partial class VepMatchingQuantityStatisticsDto
    {
        [Newtonsoft.Json.JsonProperty("marketMatchingQuantity", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? MarketMatchingQuantity { get; set; }

        [Newtonsoft.Json.JsonProperty("privateOperationQuantity", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? PrivateOperationQuantity { get; set; }

        [Newtonsoft.Json.JsonProperty("dailyIndexPriceBiddingQuantity", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? DailyIndexPriceBiddingQuantity { get; set; }

        [Newtonsoft.Json.JsonProperty("basePriceBiddingQuantity", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? BasePriceBiddingQuantity { get; set; }

        [Newtonsoft.Json.JsonProperty("defaultBiddingQuantity", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? DefaultBiddingQuantity { get; set; }

        [Newtonsoft.Json.JsonProperty("syntheticBuyMatchingQuantity", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? SyntheticBuyMatchingQuantity { get; set; }

        [Newtonsoft.Json.JsonProperty("syntheticSellMatchingQuantity", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? SyntheticSellMatchingQuantity { get; set; }

        [Newtonsoft.Json.JsonProperty("total", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? Total { get; set; }

    }

}
