namespace EpiasElectricityMarketClient.Models
{
    public partial class DeliveryYearDto
    {
        /// <summary>
        /// Yıl
        /// </summary>
        [Newtonsoft.Json.JsonProperty("year", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Year { get; set; }

    }
}
