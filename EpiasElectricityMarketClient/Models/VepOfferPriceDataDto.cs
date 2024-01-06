namespace EpiasElectricityMarketClient.Models
{
    public partial class VepOfferPriceDataDto
    {
        /// <summary>
        /// Kontrat Adı
        /// </summary>
        [Newtonsoft.Json.JsonProperty("contractName", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ContractName { get; set; }

        /// <summary>
        /// Teslimat Dönemi
        /// </summary>
        [Newtonsoft.Json.JsonProperty("deliveryPeriod", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string DeliveryPeriod { get; set; }

        /// <summary>
        /// En İyi Alış Fiyatı(TL/MWh)
        /// </summary>
        [Newtonsoft.Json.JsonProperty("bestBuyPrice", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? BestBuyPrice { get; set; }

        /// <summary>
        /// En İyi Satış Fiyatı(TL/MWh)
        /// </summary>
        [Newtonsoft.Json.JsonProperty("bestSellPrice", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? BestSellPrice { get; set; }

        /// <summary>
        /// Son Eşleşme Fiyatı(TL/MWh)
        /// </summary>
        [Newtonsoft.Json.JsonProperty("lastMatchPrice", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? LastMatchPrice { get; set; }

        /// <summary>
        /// Son Eşleşme Fiyat Değişim Oranı%
        /// </summary>
        [Newtonsoft.Json.JsonProperty("fdo", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Fdo { get; set; }

    }
}
