namespace EpiasElectricityMarketClient.Models
{
    public partial class BidOfferQuantitiesDataDto
    {
        /// <summary>
        /// Kontrat Türü;
        /// </summary>
        [Newtonsoft.Json.JsonProperty("contractType", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ContractType { get; set; }

        /// <summary>
        /// Kontrat Adı;
        /// </summary>
        [Newtonsoft.Json.JsonProperty("contractName", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ContractName { get; set; }

        /// <summary>
        /// Teklif Edilen Alış Miktarı (MWh)
        /// </summary>
        [Newtonsoft.Json.JsonProperty("bidQuantity", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? BidQuantity { get; set; }

        /// <summary>
        /// Teklif Edilen Satış Miktarı (MWh)
        /// </summary>
        [Newtonsoft.Json.JsonProperty("offerQuantity", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? OfferQuantity { get; set; }

    }

}
