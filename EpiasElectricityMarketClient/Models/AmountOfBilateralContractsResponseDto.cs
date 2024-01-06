namespace EpiasElectricityMarketClient.Models
{
    public partial class AmountOfBilateralContractsResponseDto
    {
        [Newtonsoft.Json.JsonProperty("items", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<AmountOfBilateralContractsDataDto> Items { get; set; }

        [Newtonsoft.Json.JsonProperty("page", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Page Page { get; set; }

        [Newtonsoft.Json.JsonProperty("statistics", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public AmountOfBilateralContractsStatisticsDto Statistics { get; set; }

        [Newtonsoft.Json.JsonProperty("latestUpdateDate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? LatestUpdateDate { get; set; }

    }
}
