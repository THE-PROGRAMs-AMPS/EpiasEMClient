namespace EpiasElectricityMarketClient.Models
{
    public partial class YekgTradingVolumeDataDto
    {
        /// <summary>
        /// `2023-01-01T00:00:00+03:00` formatında tarih bilgisi.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("date", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? Date { get; set; }

        /// <summary>
        /// Kaynak Tipi
        /// </summary>
        [Newtonsoft.Json.JsonProperty("resourceType", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ResourceType { get; set; }

        /// <summary>
        /// İşlem Hacmi (TL)
        /// </summary>
        [Newtonsoft.Json.JsonProperty("volumeTl", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? VolumeTl { get; set; }

        /// <summary>
        /// İşlem Hacmi (USD)
        /// </summary>
        [Newtonsoft.Json.JsonProperty("volumeUsd", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? VolumeUsd { get; set; }

        /// <summary>
        /// İşlem Hacmi (EUR)
        /// </summary>
        [Newtonsoft.Json.JsonProperty("volumeEuro", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? VolumeEuro { get; set; }

    }

}
