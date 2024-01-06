namespace EpiasElectricityMarketClient.Models
{

    public partial class RealTimeGenerationDto
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
        /// Toplam
        /// </summary>
        [Newtonsoft.Json.JsonProperty("total", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? Total { get; set; }

        /// <summary>
        /// Doğal Gaz
        /// </summary>
        [Newtonsoft.Json.JsonProperty("naturalGas", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? NaturalGas { get; set; }

        /// <summary>
        /// Barajlı
        /// </summary>
        [Newtonsoft.Json.JsonProperty("dammedHydro", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? DammedHydro { get; set; }

        /// <summary>
        /// Linyit
        /// </summary>
        [Newtonsoft.Json.JsonProperty("lignite", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? Lignite { get; set; }

        /// <summary>
        /// Akarsu
        /// </summary>
        [Newtonsoft.Json.JsonProperty("river", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? River { get; set; }

        /// <summary>
        /// İthal Kömür
        /// </summary>
        [Newtonsoft.Json.JsonProperty("importCoal", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? ImportCoal { get; set; }

        /// <summary>
        /// Rüzgar
        /// </summary>
        [Newtonsoft.Json.JsonProperty("wind", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? Wind { get; set; }

        /// <summary>
        /// Güneş
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sun", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? Sun { get; set; }

        /// <summary>
        /// Fuel Oil
        /// </summary>
        [Newtonsoft.Json.JsonProperty("fueloil", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? Fueloil { get; set; }

        /// <summary>
        /// Jeotermal
        /// </summary>
        [Newtonsoft.Json.JsonProperty("geothermal", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? Geothermal { get; set; }

        /// <summary>
        /// Asfaltit Kömür
        /// </summary>
        [Newtonsoft.Json.JsonProperty("asphaltiteCoal", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? AsphaltiteCoal { get; set; }

        /// <summary>
        /// Taş Kömür
        /// </summary>
        [Newtonsoft.Json.JsonProperty("blackCoal", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? BlackCoal { get; set; }

        /// <summary>
        /// Biyokütle
        /// </summary>
        [Newtonsoft.Json.JsonProperty("biomass", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? Biomass { get; set; }

        /// <summary>
        /// Nafta
        /// </summary>
        [Newtonsoft.Json.JsonProperty("naphta", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? Naphta { get; set; }

        /// <summary>
        /// LNG
        /// </summary>
        [Newtonsoft.Json.JsonProperty("lng", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? Lng { get; set; }

        /// <summary>
        /// Uluslararası
        /// </summary>
        [Newtonsoft.Json.JsonProperty("importExport", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? ImportExport { get; set; }

        /// <summary>
        /// Atık Isı
        /// </summary>
        [Newtonsoft.Json.JsonProperty("wasteheat", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? Wasteheat { get; set; }

    }


}
