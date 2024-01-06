namespace EpiasElectricityMarketClient.Models
{
    public partial class PriceIndependentOfferStatisticsDto
    {
        [Newtonsoft.Json.JsonProperty("offerVolumeTotal", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? OfferVolumeTotal { get; set; }

    }

}
