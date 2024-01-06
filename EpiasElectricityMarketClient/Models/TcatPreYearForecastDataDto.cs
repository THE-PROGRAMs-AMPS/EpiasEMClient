namespace EpiasElectricityMarketClient.Models
{


    public partial class TcatPreYearForecastDataDto
    {
        /// <summary>
        /// Yön Bilgisi
        /// </summary>
        [Newtonsoft.Json.JsonProperty("td", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Td { get; set; }

        /// <summary>
        /// Transfer Başlangıç Bilgisi
        /// </summary>
        [Newtonsoft.Json.JsonProperty("startsAt", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? StartsAt { get; set; }

        /// <summary>
        /// Transfer Bitiş Bilgisi
        /// </summary>
        [Newtonsoft.Json.JsonProperty("endsAt", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? EndsAt { get; set; }

        /// <summary>
        /// Bağlantı Yöntemi Bilgisi
        /// </summary>
        [Newtonsoft.Json.JsonProperty("connType", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ConnType { get; set; }

        /// <summary>
        /// NTK(MW) Bilgisi
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ntc", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? Ntc { get; set; }

        /// <summary>
        /// KAK(MW) Bilgisi
        /// </summary>
        [Newtonsoft.Json.JsonProperty("atc", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? Atc { get; set; }

        /// <summary>
        /// TEK(MW) Bilgisi
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ac", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? Ac { get; set; }

    }

}
