namespace EpiasElectricityMarketClient.Models
{


    public partial class AmountOfBilateralContractsDataDto
    {
        /// <summary>
        /// `2023-01-01T00:00:00+03:00` formatında tarih bilgisi.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("date", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? Date { get; set; }

        /// <summary>
        /// İkili Anlaşma Miktarları (TWh)
        /// </summary>
        [Newtonsoft.Json.JsonProperty("contractAmount", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? ContractAmount { get; set; }

    }
}
