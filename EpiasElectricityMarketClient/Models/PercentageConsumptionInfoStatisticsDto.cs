namespace EpiasElectricityMarketClient.Models
{
    public partial class PercentageConsumptionInfoStatisticsDto
    {
        [Newtonsoft.Json.JsonProperty("lightning", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? Lightning { get; set; }

        [Newtonsoft.Json.JsonProperty("household", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? Household { get; set; }

        [Newtonsoft.Json.JsonProperty("industry", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? Industry { get; set; }

        [Newtonsoft.Json.JsonProperty("irrigation", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? Irrigation { get; set; }

        [Newtonsoft.Json.JsonProperty("commercial", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? Commercial { get; set; }

        [Newtonsoft.Json.JsonProperty("other", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? Other { get; set; }

        [Newtonsoft.Json.JsonProperty("generalTotal", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? GeneralTotal { get; set; }

    }
}
