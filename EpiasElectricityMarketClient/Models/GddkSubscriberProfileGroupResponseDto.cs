namespace EpiasElectricityMarketClient.Models
{

    public partial class GddkSubscriberProfileGroupResponseDto
    {
        [Newtonsoft.Json.JsonProperty("items", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<LabelValueDTO> Items { get; set; }

    }
}
