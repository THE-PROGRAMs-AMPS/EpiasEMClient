namespace EpiasElectricityMarketClient.Models
{
    public partial class ConsumerQuantityDataDto
    {
        /// <summary>
        /// Şehir
        /// </summary>
        [Newtonsoft.Json.JsonProperty("province", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Province { get; set; }

        /// <summary>
        /// Profil Grubu
        /// </summary>
        [Newtonsoft.Json.JsonProperty("consumerSector", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ConsumerSector { get; set; }

        /// <summary>
        /// Serbest Tüketici Sayısı
        /// </summary>
        [Newtonsoft.Json.JsonProperty("serbestTuketiciSayisi", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public long? SerbestTuketiciSayisi { get; set; }

        /// <summary>
        /// ST Hakkı Bulunmayan Tüketici Tüketici Sayısı
        /// </summary>
        [Newtonsoft.Json.JsonProperty("stHakkiBulunmayanAboneSayisi", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public long? StHakkiBulunmayanAboneSayisi { get; set; }

        /// <summary>
        /// ST Hakkını Kullanmayan Tüketici Tüketici Sayısı
        /// </summary>
        [Newtonsoft.Json.JsonProperty("stHakkiKullanmayanAboneSayisi", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public long? StHakkiKullanmayanAboneSayisi { get; set; }

    }

}
