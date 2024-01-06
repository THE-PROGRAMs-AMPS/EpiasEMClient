namespace EpiasElectricityMarketClient.Models
{
    public partial class PortfolioIncomeDataDto
    {
        /// <summary>
        /// `2023-01-01T00:00:00+03:00` formatında tarih bilgisi.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("date", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? Date { get; set; }

        /// <summary>
        /// İlk versiyona ait ISKK değeri bilgisi
        /// </summary>
        [Newtonsoft.Json.JsonProperty("portfolioIncome", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? PortfolioIncome { get; set; }

    }
}
