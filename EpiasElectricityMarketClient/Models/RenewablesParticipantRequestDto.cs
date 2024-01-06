namespace EpiasElectricityMarketClient.Models
{
    public partial class RenewablesParticipantRequestDto
    {
        /// <summary>
        /// Yıl Bilgisi
        /// </summary>
        [Newtonsoft.Json.JsonProperty("year", Required = Newtonsoft.Json.Required.Always)]
        public double Year { get; set; }

        /// <summary>
        /// Sayfalama bilgisi.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("page", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Page Page { get; set; }

    }
}
