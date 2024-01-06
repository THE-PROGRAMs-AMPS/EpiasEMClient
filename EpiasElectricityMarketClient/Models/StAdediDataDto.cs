namespace EpiasElectricityMarketClient.Models
{
    public partial class StAdediDataDto
    {
        /// <summary>
        /// Dönem
        /// </summary>
        [Newtonsoft.Json.JsonProperty("period", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? Period { get; set; }

        /// <summary>
        /// Serbest Tüketici Hakkını Kullanan Tüketici Sayısı
        /// </summary>
        [Newtonsoft.Json.JsonProperty("stAdedi", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public long? StAdedi { get; set; }

        /// <summary>
        /// Serbest Tüketici Hakkını Kullanmayan Tüketici Sayısı
        /// </summary>
        [Newtonsoft.Json.JsonProperty("stOlmayanAboneAdedi", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public long? StOlmayanAboneAdedi { get; set; }

        /// <summary>
        /// Profil Abone Grubu
        /// </summary>
        [Newtonsoft.Json.JsonProperty("profilAboneGrup", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ProfilAboneGrup { get; set; }

    }
}
