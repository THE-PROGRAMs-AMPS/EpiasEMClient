namespace EpiasElectricityMarketClient.Models
{
    public partial class InstalledCapacityResponseInstalledCapacityOldDto
    {
        [Newtonsoft.Json.JsonProperty("installedCapacities", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<InstalledCapacityOldDto> InstalledCapacities { get; set; }

    }
}
