namespace EpiasElectricityMarketClient.Models
{
    public partial class EligibleConsumerCountDataDto
    {
        /// <summary>
        /// Dönem
        /// </summary>
        [Newtonsoft.Json.JsonProperty("period", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? Period { get; set; }

        /// <summary>
        /// Şehir Adı
        /// </summary>
        [Newtonsoft.Json.JsonProperty("provinceName", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ProvinceName { get; set; }

        /// <summary>
        /// İlçe Adı
        /// </summary>
        [Newtonsoft.Json.JsonProperty("districtName", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string DistrictName { get; set; }

        /// <summary>
        /// Profil Abone Grubu
        /// </summary>
        [Newtonsoft.Json.JsonProperty("customerProfileGroup", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string CustomerProfileGroup { get; set; }

        /// <summary>
        /// Serbest Tüketici Adedi
        /// </summary>
        [Newtonsoft.Json.JsonProperty("eligibleCount", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? EligibleCount { get; set; }

    }
}
