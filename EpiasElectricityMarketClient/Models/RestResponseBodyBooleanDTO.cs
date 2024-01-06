namespace EpiasElectricityMarketClient.Models
{
    public partial class RestResponseBodyBooleanDTO
    {
        [Newtonsoft.Json.JsonProperty("content", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public BooleanDTO Content { get; set; }

    }
}
