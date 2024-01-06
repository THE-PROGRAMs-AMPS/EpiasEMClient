namespace EpiasElectricityMarketClient.Models
{

    public partial class MarketParticipantsDataDto
    {
        /// <summary>
        /// Organizasyon Adı
        /// </summary>
        [Newtonsoft.Json.JsonProperty("orgName", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string OrgName { get; set; }

        /// <summary>
        /// GÖP Katılımı
        /// </summary>
        [Newtonsoft.Json.JsonProperty("damEntry", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? DamEntry { get; set; }

        /// <summary>
        /// GİP Katılımı
        /// </summary>
        [Newtonsoft.Json.JsonProperty("intraDayEntry", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? IntraDayEntry { get; set; }

        /// <summary>
        /// VEP Katılımı
        /// </summary>
        [Newtonsoft.Json.JsonProperty("vepEntry", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? VepEntry { get; set; }

        /// <summary>
        /// YEK-G Katılımı
        /// </summary>
        [Newtonsoft.Json.JsonProperty("yekgEntry", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? YekgEntry { get; set; }

        /// <summary>
        /// Tüzel Kişilik Durumu
        /// </summary>
        [Newtonsoft.Json.JsonProperty("legalStatus", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string LegalStatus { get; set; }

        /// <summary>
        /// Doğalgaz Katılımı
        /// </summary>
        [Newtonsoft.Json.JsonProperty("naturalGasMarketEntry", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? NaturalGasMarketEntry { get; set; }

        /// <summary>
        /// Id
        /// </summary>
        [Newtonsoft.Json.JsonProperty("id", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public long? Id { get; set; }

    }

}
