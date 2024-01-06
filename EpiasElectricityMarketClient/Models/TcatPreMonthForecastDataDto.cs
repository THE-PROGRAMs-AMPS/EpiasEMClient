namespace EpiasElectricityMarketClient.Models
{

    public partial class TcatPreMonthForecastDataDto
    {
        /// <summary>
        /// Yön
        /// </summary>
        [Newtonsoft.Json.JsonProperty("direction", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Direction { get; set; }

        /// <summary>
        /// Transfer Başlangıç
        /// </summary>
        [Newtonsoft.Json.JsonProperty("transferStart", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? TransferStart { get; set; }

        /// <summary>
        /// Transfer Bitiş
        /// </summary>
        [Newtonsoft.Json.JsonProperty("transferEnd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? TransferEnd { get; set; }

        /// <summary>
        /// Bağlantı Yöntemi
        /// </summary>
        [Newtonsoft.Json.JsonProperty("connType", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ConnType { get; set; }

        /// <summary>
        /// SEECAO/TEİAŞ adına NTK (MW)
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ntc", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? Ntc { get; set; }

        /// <summary>
        /// SEECAO/TEİAŞ adına KAK (MW)
        /// </summary>
        [Newtonsoft.Json.JsonProperty("atc", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? Atc { get; set; }

        /// <summary>
        /// SEECAO/TEİAŞ adına TEK (MW)
        /// </summary>
        [Newtonsoft.Json.JsonProperty("alloc", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? Alloc { get; set; }

    }


}
