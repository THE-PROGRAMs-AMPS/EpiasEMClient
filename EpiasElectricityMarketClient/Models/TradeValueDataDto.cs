namespace EpiasElectricityMarketClient.Models
{
    public partial class TradeValueDataDto
    {
        /// <summary>
        /// Kontrat Türü;
        /// </summary>
        [Newtonsoft.Json.JsonProperty("kontratTuru", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string KontratTuru { get; set; }

        /// <summary>
        /// Kontrat Adı;
        /// </summary>
        [Newtonsoft.Json.JsonProperty("kontratAdi", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string KontratAdi { get; set; }

        /// <summary>
        /// İşlem Hacmi (TL);
        /// </summary>
        [Newtonsoft.Json.JsonProperty("tradingVolume", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? TradingVolume { get; set; }

    }
}
