namespace EpiasElectricityMarketClient.Models
{
    public partial class ConsumerSectorResponseDto
    {
        [Newtonsoft.Json.JsonProperty("id", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public long? Id { get; set; }

        [Newtonsoft.Json.JsonProperty("consumerSectorTr", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ConsumerSectorTr { get; set; }

        [Newtonsoft.Json.JsonProperty("consumerSectorEn", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ConsumerSectorEn { get; set; }

    }
}
