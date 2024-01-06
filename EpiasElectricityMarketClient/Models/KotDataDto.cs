namespace EpiasElectricityMarketClient.Models
{

    public partial class KotDataDto
    {
        /// <summary>
        /// `2023-01-01T00:00:00+03:00` formatında tarih bilgisi.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("date", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? Date { get; set; }

        /// <summary>
        /// Havza
        /// </summary>
        [Newtonsoft.Json.JsonProperty("basinName", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string BasinName { get; set; }

        /// <summary>
        /// Baraj
        /// </summary>
        [Newtonsoft.Json.JsonProperty("damName", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string DamName { get; set; }

        /// <summary>
        /// Maksimum Kot
        /// </summary>
        [Newtonsoft.Json.JsonProperty("maxKot", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? MaxKot { get; set; }

        /// <summary>
        /// Minimum Kot
        /// </summary>
        [Newtonsoft.Json.JsonProperty("minKot", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? MinKot { get; set; }

        /// <summary>
        /// Id
        /// </summary>
        [Newtonsoft.Json.JsonProperty("id", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? Id { get; set; }

    }


}
