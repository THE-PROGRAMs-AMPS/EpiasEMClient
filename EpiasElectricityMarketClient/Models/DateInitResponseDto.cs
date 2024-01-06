namespace EpiasElectricityMarketClient.Models
{
    public partial class DateInitResponseDto
    {
        /// <summary>
        /// Bu ay
        /// </summary>
        [Newtonsoft.Json.JsonProperty("thisMonth", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? ThisMonth { get; set; }

        /// <summary>
        /// Bugün
        /// </summary>
        [Newtonsoft.Json.JsonProperty("today", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? Today { get; set; }

        /// <summary>
        /// Dün
        /// </summary>
        [Newtonsoft.Json.JsonProperty("yesterday", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? Yesterday { get; set; }

        /// <summary>
        /// Yarın
        /// </summary>
        [Newtonsoft.Json.JsonProperty("tomorrow", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? Tomorrow { get; set; }

        /// <summary>
        /// Geçen Hafta
        /// </summary>
        [Newtonsoft.Json.JsonProperty("lastWeek", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? LastWeek { get; set; }

        /// <summary>
        /// Geçen Ay
        /// </summary>
        [Newtonsoft.Json.JsonProperty("lastMonth", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? LastMonth { get; set; }

        /// <summary>
        /// Göp Ay
        /// </summary>
        [Newtonsoft.Json.JsonProperty("gopMonth", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? GopMonth { get; set; }

        /// <summary>
        /// Göp Yıl
        /// </summary>
        [Newtonsoft.Json.JsonProperty("gopYear", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? GopYear { get; set; }

        /// <summary>
        /// Gün Sonu
        /// </summary>
        [Newtonsoft.Json.JsonProperty("endOfDay", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? EndOfDay { get; set; }

        /// <summary>
        /// iskk gün
        /// </summary>
        [Newtonsoft.Json.JsonProperty("tslfDay", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? TslfDay { get; set; }

        /// <summary>
        /// Uzlaştırma Dönemi
        /// </summary>
        [Newtonsoft.Json.JsonProperty("conciliationPeriod", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? ConciliationPeriod { get; set; }

        /// <summary>
        /// Şimdi
        /// </summary>
        [Newtonsoft.Json.JsonProperty("dateUnit", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? DateUnit { get; set; }

        /// <summary>
        /// Bir yıl önceki uzlaştırma dönemi
        /// </summary>
        [Newtonsoft.Json.JsonProperty("periodBeforeYearAgo", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? PeriodBeforeYearAgo { get; set; }

        /// <summary>
        /// Uzlaştırma Ay Sonu
        /// </summary>
        [Newtonsoft.Json.JsonProperty("conciliationEndOfMonth", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? ConciliationEndOfMonth { get; set; }

        /// <summary>
        /// Arz Talep eğrisi göster
        /// </summary>
        [Newtonsoft.Json.JsonProperty("showSupplyAndDemandCurve", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? ShowSupplyAndDemandCurve { get; set; }

        /// <summary>
        /// Kgüp Eak Göster
        /// </summary>
        [Newtonsoft.Json.JsonProperty("showKgupEak", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? ShowKgupEak { get; set; }

        [Newtonsoft.Json.JsonProperty("serverTime", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? ServerTime { get; set; }

        [Newtonsoft.Json.JsonProperty("yekdemLastDate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? YekdemLastDate { get; set; }

    }

}
