namespace EpiasElectricityMarketClient.Models
{
    public partial class MaximumSettlementPriceStatisticsDto
    {
        [Newtonsoft.Json.JsonProperty("gopMaxPriceTotal", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? GopMaxPriceTotal { get; set; }

        [Newtonsoft.Json.JsonProperty("naturalGasTotal", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? NaturalGasTotal { get; set; }

        [Newtonsoft.Json.JsonProperty("importedCoalTotal", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? ImportedCoalTotal { get; set; }

        [Newtonsoft.Json.JsonProperty("localCoalTotal", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? LocalCoalTotal { get; set; }

        [Newtonsoft.Json.JsonProperty("otherTotal", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? OtherTotal { get; set; }

    }
}
