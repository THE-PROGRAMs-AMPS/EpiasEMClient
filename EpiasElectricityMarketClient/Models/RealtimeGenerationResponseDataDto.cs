namespace EpiasElectricityMarketClient.Models
{


    public partial class RealtimeGenerationResponseDataDto
    {
        /// <summary>
        /// `2023-01-01T00:00:00+03:00` formatında tarih bilgisi.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("date", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? Date { get; set; }

        /// <summary>
        /// Saat Bilgisi
        /// </summary>
        [Newtonsoft.Json.JsonProperty("hour", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? Hour { get; set; }

        /// <summary>
        /// Toplam
        /// </summary>
        [Newtonsoft.Json.JsonProperty("toplam", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? Toplam { get; set; }

        /// <summary>
        /// Rüzgar
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ruzgar", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? Ruzgar { get; set; }

        /// <summary>
        /// Jeotermal
        /// </summary>
        [Newtonsoft.Json.JsonProperty("jeotermal", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? Jeotermal { get; set; }

        /// <summary>
        /// Rezervuarlı(MWh)
        /// </summary>
        [Newtonsoft.Json.JsonProperty("rezervuarli", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? Rezervuarli { get; set; }

        /// <summary>
        /// Kanal Tipi(MWh)
        /// </summary>
        [Newtonsoft.Json.JsonProperty("kanalTipi", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? KanalTipi { get; set; }

        /// <summary>
        /// Akarsu
        /// </summary>
        [Newtonsoft.Json.JsonProperty("nehirTipi", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? NehirTipi { get; set; }

        /// <summary>
        /// Çöp Gazı(MWh)
        /// </summary>
        [Newtonsoft.Json.JsonProperty("copGazi", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? CopGazi { get; set; }

        /// <summary>
        /// Biyogaz(MWh)
        /// </summary>
        [Newtonsoft.Json.JsonProperty("biyogaz", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? Biyogaz { get; set; }

        /// <summary>
        /// Güneş
        /// </summary>
        [Newtonsoft.Json.JsonProperty("gunes", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? Gunes { get; set; }

        /// <summary>
        /// Biyokütle
        /// </summary>
        [Newtonsoft.Json.JsonProperty("biyokutle", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? Biyokutle { get; set; }

        /// <summary>
        /// Diğer(MWh)
        /// </summary>
        [Newtonsoft.Json.JsonProperty("diger", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? Diger { get; set; }

    }


}
