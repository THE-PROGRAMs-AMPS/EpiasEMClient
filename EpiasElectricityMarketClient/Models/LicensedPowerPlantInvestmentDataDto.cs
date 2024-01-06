namespace EpiasElectricityMarketClient.Models
{
    public partial class LicensedPowerPlantInvestmentDataDto
    {
        /// <summary>
        /// `2023-01-01T00:00:00+03:00` formatında tarih bilgisi.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("lisansTarihi", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? LisansTarihi { get; set; }

        /// <summary>
        /// Lisans Numarası
        /// </summary>
        [Newtonsoft.Json.JsonProperty("lisansNo", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string LisansNo { get; set; }

        /// <summary>
        /// Şirket Adı
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sirketAdi", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string SirketAdi { get; set; }

        /// <summary>
        /// Santral Adı
        /// </summary>
        [Newtonsoft.Json.JsonProperty("santralAdi", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string SantralAdi { get; set; }

        /// <summary>
        /// İl
        /// </summary>
        [Newtonsoft.Json.JsonProperty("il", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Il { get; set; }

        /// <summary>
        /// Yakıt Cinsi
        /// </summary>
        [Newtonsoft.Json.JsonProperty("yakitCinsi", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string YakitCinsi { get; set; }

        /// <summary>
        /// Unite Gücü
        /// </summary>
        [Newtonsoft.Json.JsonProperty("uniteGucu", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string UniteGucu { get; set; }

        /// <summary>
        /// Ünite Sayısı
        /// </summary>
        [Newtonsoft.Json.JsonProperty("uniteSayisi", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string UniteSayisi { get; set; }

        /// <summary>
        /// İlave Güç
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ilaveKuruluGuc", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? IlaveKuruluGuc { get; set; }

        /// <summary>
        /// Geçici Kabul Tarihi
        /// </summary>
        [Newtonsoft.Json.JsonProperty("geciciKabulTarihi", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? GeciciKabulTarihi { get; set; }

    }


}
