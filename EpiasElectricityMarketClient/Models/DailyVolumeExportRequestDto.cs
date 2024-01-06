namespace EpiasElectricityMarketClient.Models
{
    public partial class DailyVolumeExportRequestDto
    {
        /// <summary>
        /// Havza
        /// </summary>
        [Newtonsoft.Json.JsonProperty("basinName", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string BasinName { get; set; }

        /// <summary>
        /// Baraj
        /// </summary>
        [Newtonsoft.Json.JsonProperty("damName", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string DamName { get; set; }

        /// <summary>
        /// Sayfalama bilgisi.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("page", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Page Page { get; set; }

        /// <summary>
        /// XLSX, CSV ya da PDF
        /// </summary>
        [Newtonsoft.Json.JsonProperty("exportType", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public DailyVolumeExportRequestDtoExportType ExportType { get; set; }

    }
}
