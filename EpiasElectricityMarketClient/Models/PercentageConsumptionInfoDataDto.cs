namespace EpiasElectricityMarketClient.Models
{


    public partial class PercentageConsumptionInfoDataDto
    {
        /// <summary>
        /// Dönem
        /// </summary>
        [Newtonsoft.Json.JsonProperty("period", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? Period { get; set; }

        /// <summary>
        /// Şehir
        /// </summary>
        [Newtonsoft.Json.JsonProperty("province", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Province { get; set; }

        /// <summary>
        /// Aydınlatma (MWh)
        /// </summary>
        [Newtonsoft.Json.JsonProperty("lightning", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? Lightning { get; set; }

        /// <summary>
        /// Mesken (MWh)
        /// </summary>
        [Newtonsoft.Json.JsonProperty("household", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? Household { get; set; }

        /// <summary>
        /// Sanayi (MWh)
        /// </summary>
        [Newtonsoft.Json.JsonProperty("industry", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? Industry { get; set; }

        /// <summary>
        /// Tarımsal Sulama (MWh)
        /// </summary>
        [Newtonsoft.Json.JsonProperty("irrigation", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? Irrigation { get; set; }

        /// <summary>
        /// Ticarethane (MWh)
        /// </summary>
        [Newtonsoft.Json.JsonProperty("commercial", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? Commercial { get; set; }

        /// <summary>
        /// Diğer (MWh)
        /// </summary>
        [Newtonsoft.Json.JsonProperty("other", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? Other { get; set; }

        /// <summary>
        /// Genel Toplam (MWh)
        /// </summary>
        [Newtonsoft.Json.JsonProperty("generalTotal", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? GeneralTotal { get; set; }

        /// <summary>
        /// İl Bazında Tüketim Oranı (%)
        /// </summary>
        [Newtonsoft.Json.JsonProperty("consumptionRatioBasedOnProvince", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? ConsumptionRatioBasedOnProvince { get; set; }

    }


}
