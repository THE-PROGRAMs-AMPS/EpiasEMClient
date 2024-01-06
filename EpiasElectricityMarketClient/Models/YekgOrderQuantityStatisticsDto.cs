namespace EpiasElectricityMarketClient.Models
{
    public partial class YekgOrderQuantityStatisticsDto
    {
        [Newtonsoft.Json.JsonProperty("totalalisTeklifMiktari", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? TotalalisTeklifMiktari { get; set; }

        [Newtonsoft.Json.JsonProperty("totalsatisTeklifMiktari", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? TotalsatisTeklifMiktari { get; set; }

    }
}
