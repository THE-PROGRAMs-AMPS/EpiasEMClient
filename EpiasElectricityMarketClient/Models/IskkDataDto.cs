namespace EpiasElectricityMarketClient.Models
{
    public partial class IskkDataDto
    {
        /// <summary>
        /// `2023-01-01T00:00:00+03:00` formatında tarih bilgisi.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("date", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? Date { get; set; }

        /// <summary>
        /// `2023-01-01T00:00:00+03:00` formatında tarih bilgisi.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("time", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? Time { get; set; }

        /// <summary>
        /// İlk versiyona ait ISKK değeri bilgisi
        /// </summary>
        [Newtonsoft.Json.JsonProperty("firstVersionValue", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? FirstVersionValue { get; set; }

        /// <summary>
        /// Son versiyona ait ISKK değeri bilgisi
        /// </summary>
        [Newtonsoft.Json.JsonProperty("lastVersionValue", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? LastVersionValue { get; set; }

        /// <summary>
        /// Kayıp Miktarı(MWh)
        /// </summary>
        [Newtonsoft.Json.JsonProperty("difference", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? Difference { get; set; }

    }
}
