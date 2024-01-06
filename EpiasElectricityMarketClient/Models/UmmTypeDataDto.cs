namespace EpiasElectricityMarketClient.Models
{
    public partial class UmmTypeDataDto
    {
        /// <summary>
        /// Mesaj Tipi Id(bknz.Piyasa Mesaj Sistemi Mesaj Tipi Listeleme Servisi)
        /// </summary>
        [Newtonsoft.Json.JsonProperty("id", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public long? Id { get; set; }

        /// <summary>
        /// Mesaj Tipi Adı
        /// </summary>
        [Newtonsoft.Json.JsonProperty("typeName", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string TypeName { get; set; }

    }
}
