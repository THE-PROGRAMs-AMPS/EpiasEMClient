namespace EpiasElectricityMarketClient.Models
{

    public partial class PriceIndependentBidStatisticsDto
    {
        [Newtonsoft.Json.JsonProperty("bidVolumeTotal", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? BidVolumeTotal { get; set; }

    }
}
