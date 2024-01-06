namespace EpiasElectricityMarketClient.Models
{
    public partial class LoadTypeResponseDto
    {
        [Newtonsoft.Json.JsonProperty("items", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<LabelValueDTO> Items { get; set; }

    }
}
