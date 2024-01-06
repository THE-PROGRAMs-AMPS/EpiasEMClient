namespace EpiasElectricityMarketClient.Models
{
    public partial class SecondaryFrequencyCapacityAmountResponseDto
    {
        [Newtonsoft.Json.JsonProperty("items", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<SecondaryFrequencyCapacityAmountDataDto> Items { get; set; }

        [Newtonsoft.Json.JsonProperty("page", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Page Page { get; set; }

        [Newtonsoft.Json.JsonProperty("statistics", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public FrequencyCapacityAmountStatisticsDto Statistics { get; set; }

    }
}
