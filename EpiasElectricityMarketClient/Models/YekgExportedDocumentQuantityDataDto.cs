namespace EpiasElectricityMarketClient.Models
{


    public partial class YekgExportedDocumentQuantityDataDto
    {
        /// <summary>
        /// `2023-01-01T00:00:00+03:00` formatında tarih bilgisi.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("date", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? Date { get; set; }

        /// <summary>
        /// Rüzgar (MWh)
        /// </summary>
        [Newtonsoft.Json.JsonProperty("windAmount", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? WindAmount { get; set; }

        /// <summary>
        /// Güneş (MWh)
        /// </summary>
        [Newtonsoft.Json.JsonProperty("solarAmount", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? SolarAmount { get; set; }

        /// <summary>
        /// Hidro (MWh)
        /// </summary>
        [Newtonsoft.Json.JsonProperty("hydroPowerAmount", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? HydroPowerAmount { get; set; }

        /// <summary>
        /// Jeotermal (MWh)
        /// </summary>
        [Newtonsoft.Json.JsonProperty("geothermalAmount", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? GeothermalAmount { get; set; }

        /// <summary>
        /// Biyokütle (MWh)
        /// </summary>
        [Newtonsoft.Json.JsonProperty("biomassAmount", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? BiomassAmount { get; set; }

        /// <summary>
        /// Toplam (MWh)
        /// </summary>
        [Newtonsoft.Json.JsonProperty("totalAmount", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? TotalAmount { get; set; }

    }


}
