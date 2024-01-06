namespace EpiasElectricityMarketClient.Models
{
    public partial class ConsumptionQuantityExportRequestDto
    {
        /// <summary>
        /// `2023-01-01T00:00:00+03:00` formatında tarih bilgisi.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("period", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public System.DateTimeOffset Period { get; set; }

        /// <summary>
        /// Şehir Id bilgisi(bkz.Şehir Listesi Getirme Servisi)
        /// </summary>
        [Newtonsoft.Json.JsonProperty("provinceId", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? ProvinceId { get; set; }

        /// <summary>
        /// Profil grup Id bilgisi(bkz.Profil Group Listesi Getirme Servisi)
        /// </summary>
        [Newtonsoft.Json.JsonProperty("profileGroupId", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? ProfileGroupId { get; set; }

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
        public ConsumptionQuantityExportRequestDtoExportType ExportType { get; set; }

    }
}
