namespace EpiasElectricityMarketClient.Models
{
    public partial class BilateralContractSellStatisticsDto
    {
        [Newtonsoft.Json.JsonProperty("quantityTotals", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? QuantityTotals { get; set; }

    }

}
