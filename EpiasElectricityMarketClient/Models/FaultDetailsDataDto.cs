namespace EpiasElectricityMarketClient.Models
{
    public partial class FaultDetailsDataDto
    {
        /// <summary>
        /// Saat Bilgisi
        /// </summary>
        [Newtonsoft.Json.JsonProperty("hour", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? Hour { get; set; }

        /// <summary>
        /// Kalan Kapasite
        /// </summary>
        [Newtonsoft.Json.JsonProperty("remainingCapacity", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? RemainingCapacity { get; set; }

        /// <summary>
        /// Arızadan Önceki Güç
        /// </summary>
        [Newtonsoft.Json.JsonProperty("preFaultPower", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? PreFaultPower { get; set; }

        /// <summary>
        /// Arızadan Dolayı Güç Kaybı
        /// </summary>
        [Newtonsoft.Json.JsonProperty("faultCausedPowerLoss", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? FaultCausedPowerLoss { get; set; }

        /// <summary>
        /// Arızadan Dolayı Enerji Kaybı
        /// </summary>
        [Newtonsoft.Json.JsonProperty("faultCausedEnergyLoss", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? FaultCausedEnergyLoss { get; set; }

    }

}
