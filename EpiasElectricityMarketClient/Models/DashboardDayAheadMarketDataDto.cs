namespace EpiasElectricityMarketClient.Models
{
    public partial class DashboardDayAheadMarketDataDto
    {
        /// <summary>
        /// `2023-01-01T00:00:00+03:00` formatında tarih bilgisi.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("date", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? Date { get; set; }

        /// <summary>
        /// TL cinsinden PTF bilgisi (TL/MWh).
        /// </summary>
        [Newtonsoft.Json.JsonProperty("mcpTr", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? McpTr { get; set; }

        /// <summary>
        /// EUR cinsinden PTF bilgisi (EUR/MWh).
        /// </summary>
        [Newtonsoft.Json.JsonProperty("mcpEur", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? McpEur { get; set; }

        /// <summary>
        /// USD cinsinden PTF bilgisi (USD/MWh).
        /// </summary>
        [Newtonsoft.Json.JsonProperty("mcpUsd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? McpUsd { get; set; }

        /// <summary>
        /// İşlem Hacmi (TL)
        /// </summary>
        [Newtonsoft.Json.JsonProperty("volume", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? Volume { get; set; }

    }


}
