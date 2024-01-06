namespace EpiasElectricityMarketClient.Models
{
    public partial class MarketMessageSystemDataDto
    {
        /// <summary>
        /// Organizasyon Adı bilgisi
        /// </summary>
        [Newtonsoft.Json.JsonProperty("orgName", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string OrgName { get; set; }

        /// <summary>
        /// Santral adı
        /// </summary>
        [Newtonsoft.Json.JsonProperty("powerPlantName", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string PowerPlantName { get; set; }

        /// <summary>
        /// UEVÇB Adı
        /// </summary>
        [Newtonsoft.Json.JsonProperty("uevcbName", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string UevcbName { get; set; }

        /// <summary>
        /// `2023-01-01T00:00:00+03:00` formatında tarih bilgisi.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("caseStartDate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? CaseStartDate { get; set; }

        /// <summary>
        /// `2023-01-01T00:00:00+03:00` formatında tarih bilgisi.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("caseEndDate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? CaseEndDate { get; set; }

        /// <summary>
        /// Santral adı
        /// </summary>
        [Newtonsoft.Json.JsonProperty("operatorPower", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? OperatorPower { get; set; }

        /// <summary>
        /// Olay Sırasında Kapasite
        /// </summary>
        [Newtonsoft.Json.JsonProperty("capacityAtCaseTime", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? CapacityAtCaseTime { get; set; }

        /// <summary>
        /// Santral adı
        /// </summary>
        [Newtonsoft.Json.JsonProperty("reason", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Reason { get; set; }

        [Newtonsoft.Json.JsonProperty("faultDetails", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<FaultDetailsDataDto> FaultDetails { get; set; }

    }


}
