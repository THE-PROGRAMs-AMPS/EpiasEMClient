namespace EpiasElectricityMarketClient.Models
{

    public partial class YekdemYektobResponseDataDto
    {
        /// <summary>
        /// Transfer Zamanı
        /// </summary>
        [Newtonsoft.Json.JsonProperty("date", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? Date { get; set; }

        /// <summary>
        /// Toplam Gider(YEKTOB)(TL)
        /// </summary>
        [Newtonsoft.Json.JsonProperty("toplam", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? Toplam { get; set; }

        /// <summary>
        /// Rüzgar (TL)
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ruzgar", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? Ruzgar { get; set; }

        /// <summary>
        /// Jeotermal (TL)
        /// </summary>
        [Newtonsoft.Json.JsonProperty("geothermal", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? Geothermal { get; set; }

        /// <summary>
        /// Rezervuarlı (TL)
        /// </summary>
        [Newtonsoft.Json.JsonProperty("rezervuarli", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? Rezervuarli { get; set; }

        /// <summary>
        /// Kanal Tipi (TL)
        /// </summary>
        [Newtonsoft.Json.JsonProperty("kanalTipi", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? KanalTipi { get; set; }

        /// <summary>
        /// Nehir Tipi (TL)
        /// </summary>
        [Newtonsoft.Json.JsonProperty("nehirTipi", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? NehirTipi { get; set; }

        /// <summary>
        /// Çöp Gazı (TL)
        /// </summary>
        [Newtonsoft.Json.JsonProperty("copGazi", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? CopGazi { get; set; }

        /// <summary>
        /// Biogaz (TL)
        /// </summary>
        [Newtonsoft.Json.JsonProperty("biyogaz", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? Biyogaz { get; set; }

        /// <summary>
        /// Güneş (TL)
        /// </summary>
        [Newtonsoft.Json.JsonProperty("gunes", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? Gunes { get; set; }

        /// <summary>
        /// Biyokütle (TL)
        /// </summary>
        [Newtonsoft.Json.JsonProperty("biyokutle", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? Biyokutle { get; set; }

        /// <summary>
        /// Diğer (TL)
        /// </summary>
        [Newtonsoft.Json.JsonProperty("diger", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? Diger { get; set; }

    }


}
