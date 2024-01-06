namespace EpiasElectricityMarketClient.Models
{
    public partial class InstalledCapacityNewDto
    {
        /// <summary>
        /// Kaynak
        /// </summary>
        [Newtonsoft.Json.JsonProperty("renewableEnergyType", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string RenewableEnergyType { get; set; }

        /// <summary>
        /// Lisanslı Kurulu Güç(MW)
        /// </summary>
        [Newtonsoft.Json.JsonProperty("licencedCapacity", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? LicencedCapacity { get; set; }

        /// <summary>
        /// Lisanssız Kurulu Güç(MW)
        /// </summary>
        [Newtonsoft.Json.JsonProperty("unlicencedCapacity", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? UnlicencedCapacity { get; set; }

        /// <summary>
        /// Toplam(MW)
        /// </summary>
        [Newtonsoft.Json.JsonProperty("total", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? Total { get; set; }

    }
}
