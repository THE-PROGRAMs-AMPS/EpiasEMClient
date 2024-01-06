namespace EpiasElectricityMarketClient.Models
{
    public partial class InstalledCapacityResponse
    {
        [Newtonsoft.Json.JsonProperty("installedCapacities", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<BaseDTO> InstalledCapacities { get; set; }

    }

}
