namespace EpiasElectricityMarketClient.Models
{
    public partial class ConsumptionQuantityDataDto
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
        /// Serbest Tüketici Tüketim Miktarı
        /// </summary>
        [Newtonsoft.Json.JsonProperty("serbestTuketiciTuketimMiktari", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public long? SerbestTuketiciTuketimMiktari { get; set; }

        /// <summary>
        /// ST Hakkı Bulunmayan Tüketici Tüketim Miktarı
        /// </summary>
        [Newtonsoft.Json.JsonProperty("stHakkiBulunmayanTuketiciTuketimMiktari", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public long? StHakkiBulunmayanTuketiciTuketimMiktari { get; set; }

        /// <summary>
        /// ST Hakkını Kullanmayan Tüketici Tüketim Miktarı
        /// </summary>
        [Newtonsoft.Json.JsonProperty("stHakkiniKullanmayanTuketiciTuketimMiktari", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public long? StHakkiniKullanmayanTuketiciTuketimMiktari { get; set; }

    }
}
