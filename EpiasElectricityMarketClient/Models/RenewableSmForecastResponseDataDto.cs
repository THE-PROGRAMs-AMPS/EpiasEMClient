namespace EpiasElectricityMarketClient.Models
{

    public partial class RenewableSmForecastResponseDataDto
    {
        /// <summary>
        /// Transfer Zamanı
        /// </summary>
        [Newtonsoft.Json.JsonProperty("date", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? Date { get; set; }

        /// <summary>
        /// `2023-01-01T00:00:00+03:00` formatında tarih bilgisi.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("time", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? Time { get; set; }

        /// <summary>
        /// Toplam (MWh)
        /// </summary>
        [Newtonsoft.Json.JsonProperty("toplam", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? Toplam { get; set; }

        /// <summary>
        /// Rüzgar (MWh)
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ruzgar", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? Ruzgar { get; set; }

        /// <summary>
        /// Jeotermal (MWh)
        /// </summary>
        [Newtonsoft.Json.JsonProperty("geothermal", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? Geothermal { get; set; }

        /// <summary>
        /// Biogaz (MWh)
        /// </summary>
        [Newtonsoft.Json.JsonProperty("biyogaz", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? Biyogaz { get; set; }

        /// <summary>
        /// Kanal Tipi (MWh)
        /// </summary>
        [Newtonsoft.Json.JsonProperty("kanalTipi", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? KanalTipi { get; set; }

        /// <summary>
        /// Nehir Tipi (MWh)
        /// </summary>
        [Newtonsoft.Json.JsonProperty("nehirTipi", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? NehirTipi { get; set; }

        /// <summary>
        /// Biyokütle (MWh)
        /// </summary>
        [Newtonsoft.Json.JsonProperty("biyokutle", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? Biyokutle { get; set; }

        /// <summary>
        /// Çöp Gazı (MWh)
        /// </summary>
        [Newtonsoft.Json.JsonProperty("copGazi", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? CopGazi { get; set; }

        /// <summary>
        /// Rezervuarlı (MWh)
        /// </summary>
        [Newtonsoft.Json.JsonProperty("rezervuarli", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? Rezervuarli { get; set; }

    }

}
