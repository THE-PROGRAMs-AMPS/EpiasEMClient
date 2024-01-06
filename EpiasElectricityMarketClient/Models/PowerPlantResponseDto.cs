namespace EpiasElectricityMarketClient.Models
{
    public partial class PowerPlantResponseDto
    {
        [Newtonsoft.Json.JsonProperty("items", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<PowerPlantDto> Items { get; set; }

    }
}
