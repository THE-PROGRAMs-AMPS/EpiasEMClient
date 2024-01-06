namespace EpiasElectricityMarketClient.Models
{

    public partial class EakExportRequestDto
    {
        /// <summary>
        /// `2023-01-01T00:00:00+03:00` formatında tarih bilgisi.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("startDate", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public System.DateTimeOffset StartDate { get; set; }

        /// <summary>
        /// `2023-01-01T00:00:00+03:00` formatında tarih bilgisi.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("endDate", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public System.DateTimeOffset EndDate { get; set; }

        /// <summary>
        /// Bölge kısa adı (Ör: TR1 bkz.Bölge Listesi Getirme Servisi)
        /// </summary>
        [Newtonsoft.Json.JsonProperty("region", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Region { get; set; }

        /// <summary>
        /// Organizasyon Id bilgisi(bkz.Organizasyon Listesi Getirme Servisi)
        /// </summary>
        [Newtonsoft.Json.JsonProperty("organizationId", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public long? OrganizationId { get; set; }

        /// <summary>
        /// UEVÇB Id bilgisi(bkz.Uevçb Listeleme Servisi)
        /// </summary>
        [Newtonsoft.Json.JsonProperty("uevcbId", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public long? UevcbId { get; set; }

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
        public EakExportRequestDtoExportType ExportType { get; set; }

    }

}
