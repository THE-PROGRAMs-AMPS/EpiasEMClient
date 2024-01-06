namespace EpiasElectricityMarketClient.Models
{
    public partial class OrganizationDto
    {
        /// <summary>
        /// Organizasyon Id bilgisi(bkz.Organizasyon Listesi Getirme Servisi)
        /// </summary>
        [Newtonsoft.Json.JsonProperty("organizationId", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public long? OrganizationId { get; set; }

        /// <summary>
        /// Organizasyon Adı bilgisi
        /// </summary>
        [Newtonsoft.Json.JsonProperty("organizationName", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string OrganizationName { get; set; }

        /// <summary>
        /// Organizasyon Durum
        /// </summary>
        [Newtonsoft.Json.JsonProperty("organizationStatus", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string OrganizationStatus { get; set; }

        /// <summary>
        /// Organizasyon Etso Kod
        /// </summary>
        [Newtonsoft.Json.JsonProperty("organizationEtsoCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string OrganizationEtsoCode { get; set; }

        /// <summary>
        /// Organizasyon Kısa Ad
        /// </summary>
        [Newtonsoft.Json.JsonProperty("organizationShortName", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string OrganizationShortName { get; set; }

    }


}
