namespace EpiasElectricityMarketClient.Models
{
    public partial class ClearingQuantityOrgListResponseDto
    {
        [Newtonsoft.Json.JsonProperty("items", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<ClearingQuantityOrganizationDataDto> Items { get; set; }

    }
}
