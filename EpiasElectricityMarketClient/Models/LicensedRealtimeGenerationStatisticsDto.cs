namespace EpiasElectricityMarketClient.Models
{
    public partial class LicensedRealtimeGenerationStatisticsDto
    {
        [Newtonsoft.Json.JsonProperty("totalTotal", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? TotalTotal { get; set; }

        [Newtonsoft.Json.JsonProperty("windTotal", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? WindTotal { get; set; }

        [Newtonsoft.Json.JsonProperty("geothermalTotal", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? GeothermalTotal { get; set; }

        [Newtonsoft.Json.JsonProperty("reservoirTotal", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? ReservoirTotal { get; set; }

        [Newtonsoft.Json.JsonProperty("canalTypeTotal", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? CanalTypeTotal { get; set; }

        [Newtonsoft.Json.JsonProperty("riverTotal", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? RiverTotal { get; set; }

        [Newtonsoft.Json.JsonProperty("lfgTotal", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? LfgTotal { get; set; }

        [Newtonsoft.Json.JsonProperty("biogasTotal", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? BiogasTotal { get; set; }

        [Newtonsoft.Json.JsonProperty("solarTotal", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? SolarTotal { get; set; }

        [Newtonsoft.Json.JsonProperty("biomassTotal", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? BiomassTotal { get; set; }

        [Newtonsoft.Json.JsonProperty("otherTotal", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? OtherTotal { get; set; }

    }
}
