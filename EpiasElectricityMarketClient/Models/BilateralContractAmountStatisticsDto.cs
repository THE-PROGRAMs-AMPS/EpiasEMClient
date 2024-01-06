namespace EpiasElectricityMarketClient.Models
{
    public partial class BilateralContractAmountStatisticsDto
    {
        [Newtonsoft.Json.JsonProperty("windTotal", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? WindTotal { get; set; }

        [Newtonsoft.Json.JsonProperty("sunTotal", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? SunTotal { get; set; }

        [Newtonsoft.Json.JsonProperty("hydroTotal", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? HydroTotal { get; set; }

        [Newtonsoft.Json.JsonProperty("geothermalTotal", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? GeothermalTotal { get; set; }

        [Newtonsoft.Json.JsonProperty("biomassTotal", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? BiomassTotal { get; set; }

        [Newtonsoft.Json.JsonProperty("totalTotal", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? TotalTotal { get; set; }

    }
}
