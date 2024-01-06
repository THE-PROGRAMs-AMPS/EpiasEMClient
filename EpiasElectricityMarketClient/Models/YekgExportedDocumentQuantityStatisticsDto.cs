namespace EpiasElectricityMarketClient.Models
{

    public partial class YekgExportedDocumentQuantityStatisticsDto
    {
        [Newtonsoft.Json.JsonProperty("biomassAmountTotal", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? BiomassAmountTotal { get; set; }

        [Newtonsoft.Json.JsonProperty("hydroPowerAmountTotal", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? HydroPowerAmountTotal { get; set; }

        [Newtonsoft.Json.JsonProperty("windAmountTotal", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? WindAmountTotal { get; set; }

        [Newtonsoft.Json.JsonProperty("geothermalAmountTotal", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? GeothermalAmountTotal { get; set; }

        [Newtonsoft.Json.JsonProperty("solarAmountTotal", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? SolarAmountTotal { get; set; }

        [Newtonsoft.Json.JsonProperty("totalAmountTotal", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? TotalAmountTotal { get; set; }

    }
}
