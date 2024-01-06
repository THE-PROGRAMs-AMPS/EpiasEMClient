namespace EpiasElectricityMarketClient.Models
{
    public partial class MarketMessageSystemExportRequestDto
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
        /// Bölge id değeri(bknz.Piyasa Mesaj Sistemi Bölge Listeleme Servisi)
        /// </summary>
        [Newtonsoft.Json.JsonProperty("regionId", Required = Newtonsoft.Json.Required.Always)]
        public long RegionId { get; set; }

        /// <summary>
        /// Mesaj Tipi Id(bknz.Piyasa Mesaj Sistemi Mesaj Tipi Listeleme Servisi)
        /// </summary>
        [Newtonsoft.Json.JsonProperty("mesajTipId", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public long? MesajTipId { get; set; }

        /// <summary>
        /// Organizasyon Id bilgisi(bkz.Göp Eşleşme Miktarı Organizasyon Listeleme Servisi)
        /// </summary>
        [Newtonsoft.Json.JsonProperty("organizationId", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public long? OrganizationId { get; set; }

        /// <summary>
        /// UEVÇB Id bilgisi(bkz.Piyasa Mesaj Sistemi Uevçb Listeleme Servisi)
        /// </summary>
        [Newtonsoft.Json.JsonProperty("uevcbId", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public long? UevcbId { get; set; }

        /// <summary>
        /// Santral id değeri(bkz.Piyasa Mesaj Sistemi Santral Listeleme Servisi)
        /// </summary>
        [Newtonsoft.Json.JsonProperty("powerPlantId", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public long? PowerPlantId { get; set; }

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
        public MarketMessageSystemExportRequestDtoExportType ExportType { get; set; }

    }


}
