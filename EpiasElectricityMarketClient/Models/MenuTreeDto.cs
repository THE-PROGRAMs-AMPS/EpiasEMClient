namespace EpiasElectricityMarketClient.Models
{
    public partial class MenuTreeDto
    {
        [Newtonsoft.Json.JsonProperty("id", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public long? Id { get; set; }

        [Newtonsoft.Json.JsonProperty("labelTr", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string LabelTr { get; set; }

        [Newtonsoft.Json.JsonProperty("labelEn", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string LabelEn { get; set; }

        [Newtonsoft.Json.JsonProperty("menuOrder", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public long? MenuOrder { get; set; }

        [Newtonsoft.Json.JsonProperty("urlTr", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string UrlTr { get; set; }

        [Newtonsoft.Json.JsonProperty("urlEn", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string UrlEn { get; set; }

        [Newtonsoft.Json.JsonProperty("children", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<MenuTreeDto> Children { get; set; }

    }
}
