namespace EpiasElectricityMarketClient.Models
{
    public partial class DistributionCompanyResponseDto
    {
        /// <summary>
        /// Şirket adı
        /// </summary>
        [Newtonsoft.Json.JsonProperty("companyName", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string CompanyName { get; set; }

        /// <summary>
        /// Şirket Id'si
        /// </summary>
        [Newtonsoft.Json.JsonProperty("companyId", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public long? CompanyId { get; set; }

    }
}
