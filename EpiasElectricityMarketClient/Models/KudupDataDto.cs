namespace EpiasElectricityMarketClient.Models
{
    public partial class KudupDataDto
    {
        /// <summary>
        /// `2023-01-01T00:00:00+03:00` formatında tarih bilgisi.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("date", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? Date { get; set; }

        /// <summary>
        /// Saat Bilgisi
        /// </summary>
        [Newtonsoft.Json.JsonProperty("time", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Time { get; set; }

        /// <summary>
        /// Toplam Bilgisi
        /// </summary>
        [Newtonsoft.Json.JsonProperty("toplam", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? Toplam { get; set; }

        /// <summary>
        /// Doğalgaz Bilgisi
        /// </summary>
        [Newtonsoft.Json.JsonProperty("dogalgaz", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? Dogalgaz { get; set; }

        /// <summary>
        /// Rüzgar Bilgisi
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ruzgar", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? Ruzgar { get; set; }

        /// <summary>
        /// Linyit Bilgisi
        /// </summary>
        [Newtonsoft.Json.JsonProperty("linyit", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? Linyit { get; set; }

        /// <summary>
        /// Kömür Bilgisi
        /// </summary>
        [Newtonsoft.Json.JsonProperty("tasKomur", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? TasKomur { get; set; }

        /// <summary>
        /// Kömür Bilgisi
        /// </summary>
        [Newtonsoft.Json.JsonProperty("ithalKomur", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? IthalKomur { get; set; }

        /// <summary>
        /// Fueloil Bilgisi
        /// </summary>
        [Newtonsoft.Json.JsonProperty("fuelOil", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? FuelOil { get; set; }

        /// <summary>
        /// Jeotermal Bilgisi
        /// </summary>
        [Newtonsoft.Json.JsonProperty("jeotermal", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? Jeotermal { get; set; }

        /// <summary>
        /// Barajlı Bilgisi
        /// </summary>
        [Newtonsoft.Json.JsonProperty("barajli", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? Barajli { get; set; }

        /// <summary>
        /// Nafta Bilgisi
        /// </summary>
        [Newtonsoft.Json.JsonProperty("nafta", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? Nafta { get; set; }

        /// <summary>
        /// Biyokütle Bilgisi
        /// </summary>
        [Newtonsoft.Json.JsonProperty("biokutle", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? Biokutle { get; set; }

        /// <summary>
        /// Akarsu Bilgisi
        /// </summary>
        [Newtonsoft.Json.JsonProperty("akarsu", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? Akarsu { get; set; }

        /// <summary>
        /// Diğer Bilgisi
        /// </summary>
        [Newtonsoft.Json.JsonProperty("diger", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? Diger { get; set; }

    }

}
