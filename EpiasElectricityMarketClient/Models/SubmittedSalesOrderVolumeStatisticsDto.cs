namespace EpiasElectricityMarketClient.Models
{
    public partial class SubmittedSalesOrderVolumeStatisticsDto
    {
        [Newtonsoft.Json.JsonProperty("offerQuantityTotal", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? OfferQuantityTotal { get; set; }

    }
}
