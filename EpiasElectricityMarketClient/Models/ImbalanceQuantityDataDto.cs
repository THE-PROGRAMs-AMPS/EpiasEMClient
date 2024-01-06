namespace EpiasElectricityMarketClient.Models
{
    public partial class ImbalanceQuantityDataDto
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
        public string Hour { get; set; }

        /// <summary>
        /// Pozitif Dengesizlik Miktarı (MWh)
        /// </summary>
        [Newtonsoft.Json.JsonProperty("positiveImbalance", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? PositiveImbalance { get; set; }

        /// <summary>
        /// Negatif Dengesizlik Miktarı (MWh)
        /// </summary>
        [Newtonsoft.Json.JsonProperty("negativeImbalance", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? NegativeImbalance { get; set; }

    }
}
