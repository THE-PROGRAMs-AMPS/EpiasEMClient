namespace EpiasElectricityMarketClient.Models
{
    public partial class FrequencyCapacityAmountStatisticsDto
    {
        [Newtonsoft.Json.JsonProperty("amountTotal", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? AmountTotal { get; set; }

    }
}
