namespace EpiasElectricityMarketClient.Models
{
    public partial class RegionResponseDto
    {
        [Newtonsoft.Json.JsonProperty("items", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<RegionDto> Items { get; set; }

    }

}
