namespace EpiasElectricityMarketClient.Models
{
    public partial class BooleanDTO
    {
        [Newtonsoft.Json.JsonProperty("completed", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? Completed { get; set; }

    }
}
