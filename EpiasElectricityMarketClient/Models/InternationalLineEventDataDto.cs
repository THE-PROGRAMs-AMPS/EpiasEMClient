namespace EpiasElectricityMarketClient.Models
{

    public partial class InternationalLineEventDataDto
    {
        /// <summary>
        /// Başlangıç Tarihi Bilgisi
        /// </summary>
        [Newtonsoft.Json.JsonProperty("baslangicTarihi", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string BaslangicTarihi { get; set; }

        /// <summary>
        /// Başlangıç Saati Bilgisi
        /// </summary>
        [Newtonsoft.Json.JsonProperty("baslangicSaati", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string BaslangicSaati { get; set; }

        /// <summary>
        /// Bitiş Tarihi Bilgisi
        /// </summary>
        [Newtonsoft.Json.JsonProperty("bitisTarihi", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string BitisTarihi { get; set; }

        /// <summary>
        /// Bitiş Saati Bilgisi
        /// </summary>
        [Newtonsoft.Json.JsonProperty("bitisSaati", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string BitisSaati { get; set; }

        /// <summary>
        /// Kesinti Yeri Bilgisi
        /// </summary>
        [Newtonsoft.Json.JsonProperty("hatAdi", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string HatAdi { get; set; }

        /// <summary>
        /// Kesinti Türü Bilgisi
        /// </summary>
        [Newtonsoft.Json.JsonProperty("olayTuru", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string OlayTuru { get; set; }

        /// <summary>
        /// Kesinti Sebebi(Bakım/Arıza) Bilgisi
        /// </summary>
        [Newtonsoft.Json.JsonProperty("aciklama", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Aciklama { get; set; }

    }

}
