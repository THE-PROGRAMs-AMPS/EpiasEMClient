namespace EpiasElectricityMarketClient.Models
{


    public partial class MaximumSettlementPriceDataDto
    {
        /// <summary>
        /// `2023-01-01T00:00:00+03:00` formatında tarih bilgisi.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("period", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? Period { get; set; }

        /// <summary>
        /// `2023-01-01T00:00:00+03:00` formatında tarih bilgisi.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("startDate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? StartDate { get; set; }

        /// <summary>
        /// `2023-01-01T00:00:00+03:00` formatında tarih bilgisi.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("endDate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? EndDate { get; set; }

        /// <summary>
        /// Göp Azami Fiyat (TL/MWh)
        /// </summary>
        [Newtonsoft.Json.JsonProperty("gopMaxPrice", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? GopMaxPrice { get; set; }

        /// <summary>
        /// Doğalgaz/Fuel Oil/Nafta/LPG/Motorin (TL/MWh)
        /// </summary>
        [Newtonsoft.Json.JsonProperty("naturalGas", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? NaturalGas { get; set; }

        /// <summary>
        /// İthal Kömür (TL/MWh)
        /// </summary>
        [Newtonsoft.Json.JsonProperty("importedCoal", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? ImportedCoal { get; set; }

        /// <summary>
        /// Yerli Kömür (TL/MWh)
        /// </summary>
        [Newtonsoft.Json.JsonProperty("localCoal", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? LocalCoal { get; set; }

        /// <summary>
        /// Diğer Kaynaklar (TL/MWh)
        /// </summary>
        [Newtonsoft.Json.JsonProperty("other", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? Other { get; set; }

    }

}
