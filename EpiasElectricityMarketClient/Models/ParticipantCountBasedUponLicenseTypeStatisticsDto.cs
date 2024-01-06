namespace EpiasElectricityMarketClient.Models
{
    public partial class ParticipantCountBasedUponLicenseTypeStatisticsDto
    {
        [Newtonsoft.Json.JsonProperty("publicCompanyTotal", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? PublicCompanyTotal { get; set; }

        [Newtonsoft.Json.JsonProperty("privateSectorTotal", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? PrivateSectorTotal { get; set; }

        [Newtonsoft.Json.JsonProperty("organizationCountTotal", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? OrganizationCountTotal { get; set; }

    }
}
