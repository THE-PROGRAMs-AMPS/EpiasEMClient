namespace EpiasElectricityMarketClient.Models
{

    public partial class BilateralContractAmountDataDto
    {
        /// <summary>
        /// `2023-01-01T00:00:00+03:00` formatında tarih bilgisi.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("date", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? Date { get; set; }

        /// <summary>
        /// Rüzgar (MWh)
        /// </summary>
        [Newtonsoft.Json.JsonProperty("wind", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? Wind { get; set; }

        /// <summary>
        /// Güneş (MWh)
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sun", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? Sun { get; set; }

        /// <summary>
        /// Hidro (MWh)
        /// </summary>
        [Newtonsoft.Json.JsonProperty("hydro", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? Hydro { get; set; }

        /// <summary>
        /// Jeotermal (MWh)
        /// </summary>
        [Newtonsoft.Json.JsonProperty("geothermal", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? Geothermal { get; set; }

        /// <summary>
        /// Biyokütle (MWh)
        /// </summary>
        [Newtonsoft.Json.JsonProperty("biomass", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? Biomass { get; set; }

        /// <summary>
        /// Toplam (MWh)
        /// </summary>
        [Newtonsoft.Json.JsonProperty("total", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? Total { get; set; }

    }

}
