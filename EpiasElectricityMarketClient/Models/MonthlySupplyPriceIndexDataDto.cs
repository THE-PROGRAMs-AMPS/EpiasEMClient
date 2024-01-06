namespace EpiasElectricityMarketClient.Models
{
    public partial class MonthlySupplyPriceIndexDataDto
    {
        /// <summary>
        /// Ana Tarife Grubu
        /// </summary>
        [Newtonsoft.Json.JsonProperty("mainTariffGroupName", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string MainTariffGroupName { get; set; }

        /// <summary>
        /// Dönem
        /// </summary>
        [Newtonsoft.Json.JsonProperty("period", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? Period { get; set; }

        /// <summary>
        /// Alt Endex
        /// </summary>
        [Newtonsoft.Json.JsonProperty("subIndex", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? SubIndex { get; set; }

        /// <summary>
        /// Üst Endex
        /// </summary>
        [Newtonsoft.Json.JsonProperty("topIndex", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? TopIndex { get; set; }

    }
}
