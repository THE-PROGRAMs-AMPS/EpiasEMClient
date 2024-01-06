namespace EpiasElectricityMarketClient.Models
{
    public partial class SystemMarginalPriceStatisticsDto
    {
        [Newtonsoft.Json.JsonProperty("smpArithmeticalAverage", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? SmpArithmeticalAverage { get; set; }

    }
}
