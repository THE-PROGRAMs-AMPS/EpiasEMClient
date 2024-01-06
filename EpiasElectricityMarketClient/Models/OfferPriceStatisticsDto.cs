namespace EpiasElectricityMarketClient.Models
{

    public partial class OfferPriceStatisticsDto
    {
        [Newtonsoft.Json.JsonProperty("bestBuyPriceTotal", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? BestBuyPriceTotal { get; set; }

        [Newtonsoft.Json.JsonProperty("bestSellPriceTotal", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? BestSellPriceTotal { get; set; }

        [Newtonsoft.Json.JsonProperty("lastMatchPriceTotal", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? LastMatchPriceTotal { get; set; }

    }

}
