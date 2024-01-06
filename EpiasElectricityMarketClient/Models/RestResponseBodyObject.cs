namespace EpiasElectricityMarketClient.Models
{
    public partial class RestResponseBodyObject
    {
        [Newtonsoft.Json.JsonProperty("content", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public object Content { get; set; }

    }

}
