namespace EpiasElectricityMarketClient.Models
{
    public partial class WaterEnergyProvisionDataDto
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
        /// Suyun Enerji Karşılığı (MWh)
        /// </summary>
        [Newtonsoft.Json.JsonProperty("energyGeneration", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? EnergyGeneration { get; set; }

        /// <summary>
        /// Baraj Id
        /// </summary>
        [Newtonsoft.Json.JsonProperty("damId", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public long? DamId { get; set; }

    }
}
