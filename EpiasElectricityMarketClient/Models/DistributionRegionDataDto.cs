namespace EpiasElectricityMarketClient.Models
{
    public partial class DistributionRegionDataDto
    {
        /// <summary>
        /// Dağıtım Firma ID
        /// </summary>
        [Newtonsoft.Json.JsonProperty("distributeId", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public long? DistributeId { get; set; }

        /// <summary>
        /// Dağıtım Kodu
        /// </summary>
        [Newtonsoft.Json.JsonProperty("distributeCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string DistributeCode { get; set; }

    }
}
