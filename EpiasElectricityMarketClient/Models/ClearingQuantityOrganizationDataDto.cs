namespace EpiasElectricityMarketClient.Models
{
    public partial class ClearingQuantityOrganizationDataDto
    {
        [Newtonsoft.Json.JsonProperty("organizationId", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public long? OrganizationId { get; set; }

        [Newtonsoft.Json.JsonProperty("organizationName", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string OrganizationName { get; set; }

        [Newtonsoft.Json.JsonProperty("eic", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Eic { get; set; }

        [Newtonsoft.Json.JsonProperty("shortName", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ShortName { get; set; }

        [Newtonsoft.Json.JsonProperty("organizationStatus", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string OrganizationStatus { get; set; }

    }
}
