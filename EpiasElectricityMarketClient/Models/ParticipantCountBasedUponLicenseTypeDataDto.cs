namespace EpiasElectricityMarketClient.Models
{

    public partial class ParticipantCountBasedUponLicenseTypeDataDto
    {
        /// <summary>
        /// Lisans Türü
        /// </summary>
        [Newtonsoft.Json.JsonProperty("licence", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Licence { get; set; }

        /// <summary>
        /// Kamu Kuruluşu Katılımcı Sayısı
        /// </summary>
        [Newtonsoft.Json.JsonProperty("publicCompany", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? PublicCompany { get; set; }

        /// <summary>
        /// Özel Sektör Katılımcı Sayısı
        /// </summary>
        [Newtonsoft.Json.JsonProperty("privateSector", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? PrivateSector { get; set; }

        /// <summary>
        /// Organizasyon Adet
        /// </summary>
        [Newtonsoft.Json.JsonProperty("organizationCount", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? OrganizationCount { get; set; }

        [Newtonsoft.Json.JsonProperty("licenceId", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public long? LicenceId { get; set; }

    }

}
