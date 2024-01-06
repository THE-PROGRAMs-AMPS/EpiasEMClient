namespace EpiasElectricityMarketClient.Models
{
    public partial class DataUpdatesRequestDto
    {
        [Newtonsoft.Json.JsonProperty("menuId", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public long? MenuId { get; set; }

    }

}
