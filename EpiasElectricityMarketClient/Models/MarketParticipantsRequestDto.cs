namespace EpiasElectricityMarketClient.Models
{
    public partial class MarketParticipantsRequestDto
    {
        /// <summary>
        /// Organizasyon Id bilgisi(bkz.Organizasyon Listesi Getirme Servisi)
        /// </summary>
        [Newtonsoft.Json.JsonProperty("organizationId", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public long? OrganizationId { get; set; }

        /// <summary>
        /// Sayfalama bilgisi.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("page", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Page Page { get; set; }

    }
}
