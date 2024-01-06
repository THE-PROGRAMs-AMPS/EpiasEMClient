namespace EpiasElectricityMarketClient.Models
{

    public partial class InjectionQuantityDto
    {
        /// <summary>
        /// `2023-01-01T00:00:00+03:00` formatında tarih bilgisi.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("date", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? Date { get; set; }

        /// <summary>
        /// İlgili değerin geçerli olduğu saat bilgisi
        /// </summary>
        [Newtonsoft.Json.JsonProperty("hour", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? Hour { get; set; }

        /// <summary>
        /// Toplam kgüp değeri bilgisi.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("total", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? Total { get; set; }

        /// <summary>
        /// Doğalgaz kaynak tipinde UEVM değeri bilgisi
        /// </summary>
        [Newtonsoft.Json.JsonProperty("naturalGas", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? NaturalGas { get; set; }

        /// <summary>
        /// Barajlı kaynak tipinde UEVM değeri bilgisi
        /// </summary>
        [Newtonsoft.Json.JsonProperty("dam", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? Dam { get; set; }

        /// <summary>
        /// Linyit kaynak tipinde UEVM değeri bilgisi
        /// </summary>
        [Newtonsoft.Json.JsonProperty("lignite", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? Lignite { get; set; }

        /// <summary>
        /// Akarsu kaynak tipinde UEVM değeri bilgisi
        /// </summary>
        [Newtonsoft.Json.JsonProperty("river", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? River { get; set; }

        /// <summary>
        /// İthal kömür kaynak tipinde UEVM değeri bilgisi
        /// </summary>
        [Newtonsoft.Json.JsonProperty("importedCoal", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? ImportedCoal { get; set; }

        /// <summary>
        /// Güneş UEVM değeri bilgisi
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sun", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? Sun { get; set; }

        /// <summary>
        /// Rüzgar kaynak tipinde UEVM değeri bilgisi
        /// </summary>
        [Newtonsoft.Json.JsonProperty("wind", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? Wind { get; set; }

        /// <summary>
        /// Fuel oil kaynak tipinde UEVM değeri bilgisi
        /// </summary>
        [Newtonsoft.Json.JsonProperty("fueloil", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? Fueloil { get; set; }

        /// <summary>
        /// Jeotermal kaynak tipinde UEVM değeri bilgisi
        /// </summary>
        [Newtonsoft.Json.JsonProperty("geothermal", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? Geothermal { get; set; }

        /// <summary>
        /// Asfaltit kaynak tipinde UEVM değeri bilgisi
        /// </summary>
        [Newtonsoft.Json.JsonProperty("asphaltite", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? Asphaltite { get; set; }

        /// <summary>
        /// Taşkömür kaynak tipinde UEVM değeri bilgisi
        /// </summary>
        [Newtonsoft.Json.JsonProperty("stoneCoal", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? StoneCoal { get; set; }

        /// <summary>
        /// Biokütle kaynak tipinde UEVM değeri bilgisi
        /// </summary>
        [Newtonsoft.Json.JsonProperty("biomass", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? Biomass { get; set; }

        /// <summary>
        /// Nafta kaynak tipinde UEVM değeri bilgisi
        /// </summary>
        [Newtonsoft.Json.JsonProperty("naphtha", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? Naphtha { get; set; }

        /// <summary>
        /// LNG kaynak tipinde UEVM değeri bilgisi
        /// </summary>
        [Newtonsoft.Json.JsonProperty("lng", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? Lng { get; set; }

        /// <summary>
        /// Uluslararası ithalat UEVM değeri bilgisi
        /// </summary>
        [Newtonsoft.Json.JsonProperty("internationalImport", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? InternationalImport { get; set; }

        /// <summary>
        /// Uluslararası İhracat UEVM değeri bilgisi
        /// </summary>
        [Newtonsoft.Json.JsonProperty("internationalExport", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? InternationalExport { get; set; }

        /// <summary>
        /// Diğer kaynak tipinde UEVM değeri bilgisi
        /// </summary>
        [Newtonsoft.Json.JsonProperty("other", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? Other { get; set; }

    }

}
