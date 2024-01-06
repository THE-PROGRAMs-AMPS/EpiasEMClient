namespace EpiasElectricityMarketClient.Models
{
    public partial class MeterVolumeDataDto
    {
        /// <summary>
        /// `2023-01-01T00:00:00+03:00` formatında tarih bilgisi.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("period", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? Period { get; set; }

        /// <summary>
        /// `2023-01-01T00:00:00+03:00` formatında tarih bilgisi.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("version", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? Version { get; set; }

        /// <summary>
        /// Profil Abone Grubu
        /// </summary>
        [Newtonsoft.Json.JsonProperty("subscriberProfileGroup", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string SubscriberProfileGroup { get; set; }

        /// <summary>
        /// Çekiş Artışı (MWh)
        /// </summary>
        [Newtonsoft.Json.JsonProperty("cekisArtis", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? CekisArtis { get; set; }

        /// <summary>
        /// Çekiş Azalışı (MWh)
        /// </summary>
        [Newtonsoft.Json.JsonProperty("cekisAzalis", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? CekisAzalis { get; set; }

        /// <summary>
        /// Veriş Artışı (MWh)
        /// </summary>
        [Newtonsoft.Json.JsonProperty("verisArtis", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? VerisArtis { get; set; }

        /// <summary>
        /// Veriş Azalışı (MWh)
        /// </summary>
        [Newtonsoft.Json.JsonProperty("verisAzalis", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? VerisAzalis { get; set; }

    }


}
