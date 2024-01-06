namespace EpiasElectricityMarketClient.Models
{
    public partial class SidePaymentStatisticsDto
    {
        [Newtonsoft.Json.JsonProperty("originatingFromBidsTotal", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? OriginatingFromBidsTotal { get; set; }

        [Newtonsoft.Json.JsonProperty("originatingFromOffersTotal", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? OriginatingFromOffersTotal { get; set; }

        [Newtonsoft.Json.JsonProperty("originatingFromRoundingTotal", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? OriginatingFromRoundingTotal { get; set; }

        [Newtonsoft.Json.JsonProperty("total", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? Total { get; set; }

    }
}
