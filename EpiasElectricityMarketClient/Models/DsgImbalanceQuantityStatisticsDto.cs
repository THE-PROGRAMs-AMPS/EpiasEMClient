namespace EpiasElectricityMarketClient.Models
{
    public partial class DsgImbalanceQuantityStatisticsDto
    {
        [Newtonsoft.Json.JsonProperty("positiveImbalanceQuantityTotal", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? PositiveImbalanceQuantityTotal { get; set; }

        [Newtonsoft.Json.JsonProperty("negativeImbalanceQuantityTotal", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? NegativeImbalanceQuantityTotal { get; set; }

    }

}
