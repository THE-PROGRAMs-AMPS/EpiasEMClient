namespace EpiasElectricityMarketClient.Models
{
    public partial class EligibleConsumerQuantityDataDto
    {
        /// <summary>
        /// Dönem
        /// </summary>
        [Newtonsoft.Json.JsonProperty("period", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? Period { get; set; }

        /// <summary>
        /// Serbest Tüketici Hakkını Kullanan Tüketicilerin Tüketim Miktarı
        /// </summary>
        [Newtonsoft.Json.JsonProperty("quantityOfUsingEligibleConsumer", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? QuantityOfUsingEligibleConsumer { get; set; }

        /// <summary>
        /// Serbest Tüketici Hakkını Kullanmayan Tüketicilerin Tüketim Miktarı
        /// </summary>
        [Newtonsoft.Json.JsonProperty("quantityOfNotUsingEligibleConsumer", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? QuantityOfNotUsingEligibleConsumer { get; set; }

        /// <summary>
        /// Profil abone grubu ad bilgisidir.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("profilAboneGrupAdi", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ProfilAboneGrupAdi { get; set; }

    }
}
