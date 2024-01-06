namespace EpiasElectricityMarketClient.Models
{
    public partial class UevcbResponseDto
    {
        [Newtonsoft.Json.JsonProperty("items", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<UevcbDto> Items { get; set; }

    }
}
