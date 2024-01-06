namespace EpiasElectricityMarketClient.Models
{
    public partial class AmountOfBilateralContractsStatisticsDto
    {
        [Newtonsoft.Json.JsonProperty("totalContractAmount", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? TotalContractAmount { get; set; }

    }

}
