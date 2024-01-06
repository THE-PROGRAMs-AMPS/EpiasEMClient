namespace EpiasElectricityMarketClient.Models
{
    public partial class DsgImbalanceQuantityDataDto
    {
        /// <summary>
        /// `2023-01-01T00:00:00+03:00` formatında tarih bilgisi.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("date", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? Date { get; set; }

        /// <summary>
        /// Pozitif Dengesizlik Miktarı (MWh)
        /// </summary>
        [Newtonsoft.Json.JsonProperty("positiveImbalanceQuantity", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? PositiveImbalanceQuantity { get; set; }

        /// <summary>
        /// Negatif Dengesizlik Miktarı (MWh)
        /// </summary>
        [Newtonsoft.Json.JsonProperty("negativeImbalanceQuantity", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? NegativeImbalanceQuantity { get; set; }

    }

}
