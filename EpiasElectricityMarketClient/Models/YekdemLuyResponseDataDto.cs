namespace EpiasElectricityMarketClient.Models
{


    public partial class YekdemLuyResponseDataDto
    {
        /// <summary>
        /// `2023-01-01T00:00:00+03:00` formatında tarih bilgisi.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("date", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? Date { get; set; }

        /// <summary>
        /// Toplam YEKDEM Lisanssız Üretim Bedeli (TL)
        /// </summary>
        [Newtonsoft.Json.JsonProperty("toplam", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? Toplam { get; set; }

        /// <summary>
        /// Rüzgar (TL)
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ruzgar", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? Ruzgar { get; set; }

        /// <summary>
        /// Biogaz (TL)
        /// </summary>
        [Newtonsoft.Json.JsonProperty("biyogaz", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? Biyogaz { get; set; }

        /// <summary>
        /// Kanal Tipi (TL)
        /// </summary>
        [Newtonsoft.Json.JsonProperty("kanalTipi", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? KanalTipi { get; set; }

        /// <summary>
        /// Biyokütle (TL)
        /// </summary>
        [Newtonsoft.Json.JsonProperty("biyokutle", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? Biyokutle { get; set; }

        /// <summary>
        /// Güneş (TL)
        /// </summary>
        [Newtonsoft.Json.JsonProperty("gunes", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? Gunes { get; set; }

        /// <summary>
        /// Diğer (TL)
        /// </summary>
        [Newtonsoft.Json.JsonProperty("diger", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? Diger { get; set; }

    }

}
