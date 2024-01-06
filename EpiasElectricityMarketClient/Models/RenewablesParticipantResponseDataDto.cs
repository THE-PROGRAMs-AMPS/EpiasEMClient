namespace EpiasElectricityMarketClient.Models
{

    public partial class RenewablesParticipantResponseDataDto
    {
        /// <summary>
        /// Organizasyon Adı
        /// </summary>
        [Newtonsoft.Json.JsonProperty("orgName", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string OrgName { get; set; }

        /// <summary>
        /// Tesis Adı
        /// </summary>
        [Newtonsoft.Json.JsonProperty("facilityName", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string FacilityName { get; set; }

        /// <summary>
        /// Tesis Tipi
        /// </summary>
        [Newtonsoft.Json.JsonProperty("facilityType", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string FacilityType { get; set; }

        /// <summary>
        /// Kurulu Güç (MWe)
        /// </summary>
        [Newtonsoft.Json.JsonProperty("installedPower", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? InstalledPower { get; set; }

        /// <summary>
        /// İşletmedeki Ünite Sayısı
        /// </summary>
        [Newtonsoft.Json.JsonProperty("unitCount", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public long? UnitCount { get; set; }

        /// <summary>
        /// Lisansa Derç Edilen Yıllık Üretim Miktarı (MWh)
        /// </summary>
        [Newtonsoft.Json.JsonProperty("licencedYearlyGenerationAmount", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? LicencedYearlyGenerationAmount { get; set; }

        /// <summary>
        /// Önceki Yıl Gerçekleştirilen Üretim Miktarı (MWh)
        /// </summary>
        [Newtonsoft.Json.JsonProperty("lastYearGenerationAmount", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? LastYearGenerationAmount { get; set; }

        /// <summary>
        /// İşletmeye Giriş Tarihi
        /// </summary>
        [Newtonsoft.Json.JsonProperty("entryDate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? EntryDate { get; set; }

        /// <summary>
        /// Son Yararlanma Dönemi (Yıl)
        /// </summary>
        [Newtonsoft.Json.JsonProperty("latestUtilizationPeriod", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public long? LatestUtilizationPeriod { get; set; }

        /// <summary>
        /// Yararlanma Dönemi
        /// </summary>
        [Newtonsoft.Json.JsonProperty("utilizationPeriod", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public long? UtilizationPeriod { get; set; }

        /// <summary>
        /// YEK Fiyatı
        /// </summary>
        [Newtonsoft.Json.JsonProperty("yekPrice", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? YekPrice { get; set; }

    }

}
