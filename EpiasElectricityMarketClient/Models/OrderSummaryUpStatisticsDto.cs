namespace EpiasElectricityMarketClient.Models
{
    public partial class OrderSummaryUpStatisticsDto
    {
        [Newtonsoft.Json.JsonProperty("upRegulationZeroCodedTotal", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? UpRegulationZeroCodedTotal { get; set; }

        [Newtonsoft.Json.JsonProperty("upRegulationOneCodedTotal", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? UpRegulationOneCodedTotal { get; set; }

        [Newtonsoft.Json.JsonProperty("upRegulationTwoCodedTotal", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? UpRegulationTwoCodedTotal { get; set; }

    }

}
