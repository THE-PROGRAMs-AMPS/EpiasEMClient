namespace EpiasElectricityMarketClient.Models
{
    public partial class MenuSettingsResponseDto
    {
        [Newtonsoft.Json.JsonProperty("menuId", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public long? MenuId { get; set; }

        /// <summary>
        /// Sayfa TR açıklaması
        /// </summary>
        [Newtonsoft.Json.JsonProperty("descriptionTr", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string DescriptionTr { get; set; }

        /// <summary>
        /// Sayfa EN açıklaması
        /// </summary>
        [Newtonsoft.Json.JsonProperty("descriptionEn", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string DescriptionEn { get; set; }

        /// <summary>
        /// Türkçe olarak, sayfa verisi geçmişi ile ilgili metinsel bilgi
        /// </summary>
        [Newtonsoft.Json.JsonProperty("historyTr", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string HistoryTr { get; set; }

        /// <summary>
        /// Ingilizce olarak, sayfa verisi geçmişi ile ilgili metinsel bilgi
        /// </summary>
        [Newtonsoft.Json.JsonProperty("historyEn", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string HistoryEn { get; set; }

        /// <summary>
        /// Veri aralık sınır tipi. GUN,AY,YIL seçeneğinde enum olacak
        /// </summary>
        [Newtonsoft.Json.JsonProperty("rangeType", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string RangeType { get; set; }

        /// <summary>
        /// Veri aralik maksimum sınırı
        /// </summary>
        [Newtonsoft.Json.JsonProperty("rangeMaxValue", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public long? RangeMaxValue { get; set; }

        /// <summary>
        /// Sayfa Kaynağı Türkçe
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sourceTr", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string SourceTr { get; set; }

        /// <summary>
        /// Sayfa Kaynağı İngilizce
        /// </summary>
        [Newtonsoft.Json.JsonProperty("sourceEn", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string SourceEn { get; set; }

        /// <summary>
        /// SEO Keywords TR
        /// </summary>
        [Newtonsoft.Json.JsonProperty("seoKeywordsTr", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string SeoKeywordsTr { get; set; }

        /// <summary>
        /// SEO Keywords EN
        /// </summary>
        [Newtonsoft.Json.JsonProperty("seoKeywordsEn", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string SeoKeywordsEn { get; set; }

    }


}
