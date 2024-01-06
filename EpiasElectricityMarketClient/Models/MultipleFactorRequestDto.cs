namespace EpiasElectricityMarketClient.Models
{
    public partial class MultipleFactorRequestDto
    {
        /// <summary>
        /// `2023-01-01T00:00:00+03:00` formatında tarih bilgisi.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("period", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public System.DateTimeOffset Period { get; set; }

        /// <summary>
        /// Dağıtım Firma ID
        /// </summary>
        [Newtonsoft.Json.JsonProperty("distributionId", Required = Newtonsoft.Json.Required.Always)]
        public long DistributionId { get; set; }

        /// <summary>
        /// Sayaç Okuma Tipi
        /// </summary>
        [Newtonsoft.Json.JsonProperty("meterReadingType", Required = Newtonsoft.Json.Required.Always)]
        public long MeterReadingType { get; set; }

        /// <summary>
        /// Profil Abone Grubu
        /// </summary>
        [Newtonsoft.Json.JsonProperty("subscriberProfileGroup", Required = Newtonsoft.Json.Required.Always)]
        public long SubscriberProfileGroup { get; set; }

        /// <summary>
        /// Sayfalama bilgisi.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("page", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Page Page { get; set; }

    }
}
