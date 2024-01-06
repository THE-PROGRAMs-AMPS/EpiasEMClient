namespace EpiasElectricityMarketClient.Models
{
    public partial class OrganizationResponseDto
    {
        [Newtonsoft.Json.JsonProperty("items", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<OrganizationDto> Items { get; set; }

    }
}
