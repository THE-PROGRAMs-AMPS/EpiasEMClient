namespace EpiasElectricityMarketClient.Models
{
    public partial class OrderSummaryDownStatisticsDto
    {
        [Newtonsoft.Json.JsonProperty("downRegulationZeroCodedTotal", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? DownRegulationZeroCodedTotal { get; set; }

        [Newtonsoft.Json.JsonProperty("downRegulationOneCodedTotal", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? DownRegulationOneCodedTotal { get; set; }

        [Newtonsoft.Json.JsonProperty("downRegulationTwoCodedTotal", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? DownRegulationTwoCodedTotal { get; set; }

    }
}
