namespace EpiasElectricityMarketClient.Models
{
    public partial class RenewableUnlicencedGenerationAmountResponseStatisticsDto
    {
        [Newtonsoft.Json.JsonProperty("total", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? Total { get; set; }

    }
}
