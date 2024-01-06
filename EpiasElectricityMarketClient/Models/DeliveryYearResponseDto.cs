namespace EpiasElectricityMarketClient.Models
{
    public partial class DeliveryYearResponseDto
    {
        [Newtonsoft.Json.JsonProperty("items", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<DeliveryYearDto> Items { get; set; }

    }
}
