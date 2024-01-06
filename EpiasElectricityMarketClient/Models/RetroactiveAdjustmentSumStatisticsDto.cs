namespace EpiasElectricityMarketClient.Models
{
    public partial class RetroactiveAdjustmentSumStatisticsDto
    {
        [Newtonsoft.Json.JsonProperty("gddkCreditAmountTotal", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? GddkCreditAmountTotal { get; set; }

        [Newtonsoft.Json.JsonProperty("gddkDebtAmountTotal", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? GddkDebtAmountTotal { get; set; }

        [Newtonsoft.Json.JsonProperty("gddkNetAmountTotal", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? GddkNetAmountTotal { get; set; }

    }

}
