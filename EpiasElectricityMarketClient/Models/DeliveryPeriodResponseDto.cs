namespace EpiasElectricityMarketClient.Models
{
    public partial class DeliveryPeriodResponseDto
    {
        [Newtonsoft.Json.JsonProperty("items", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<LabelValueDTO> Items { get; set; }

    }
}
