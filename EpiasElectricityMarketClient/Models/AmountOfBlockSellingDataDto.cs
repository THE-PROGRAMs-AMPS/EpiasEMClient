namespace EpiasElectricityMarketClient.Models
{
    public partial class AmountOfBlockSellingDataDto
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
        /// Eşleşen Blok Satış Miktarları (MWh)
        /// </summary>
        [Newtonsoft.Json.JsonProperty("amountOfSalesTowardsMatchedBlock", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? AmountOfSalesTowardsMatchedBlock { get; set; }

        /// <summary>
        /// Eşleşmemiş Blok Satış Miktarları (MWh)
        /// </summary>
        [Newtonsoft.Json.JsonProperty("amountOfSalesTowardsUnMatchedBlock", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? AmountOfSalesTowardsUnMatchedBlock { get; set; }

    }
}
