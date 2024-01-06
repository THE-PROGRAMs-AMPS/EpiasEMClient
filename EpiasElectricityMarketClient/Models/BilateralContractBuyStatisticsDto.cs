namespace EpiasElectricityMarketClient.Models
{
    public partial class BilateralContractBuyStatisticsDto
    {
        [Newtonsoft.Json.JsonProperty("quantityTotals", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? QuantityTotals { get; set; }

    }
}
