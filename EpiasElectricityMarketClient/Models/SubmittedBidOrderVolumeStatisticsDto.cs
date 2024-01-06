namespace EpiasElectricityMarketClient.Models
{

    public partial class SubmittedBidOrderVolumeStatisticsDto
    {
        [Newtonsoft.Json.JsonProperty("bidQuantityTotal", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? BidQuantityTotal { get; set; }

    }

}
