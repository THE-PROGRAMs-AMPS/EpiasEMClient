namespace EpiasElectricityMarketClient.Models
{
    public partial class InstalledCapacityResponseInstalledCapacityNewDto
    {
        [Newtonsoft.Json.JsonProperty("installedCapacities", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<InstalledCapacityNewDto> InstalledCapacities { get; set; }

    }
}
