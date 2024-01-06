namespace EpiasElectricityMarketClient.Models
{
    public partial class UmmTypeResponseDto
    {
        [Newtonsoft.Json.JsonProperty("items", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<UmmTypeDataDto> Items { get; set; }

    }
}
