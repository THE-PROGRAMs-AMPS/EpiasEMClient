namespace EpiasElectricityMarketClient.Models
{
    public partial class CapacityDemandDataDto
    {
        /// <summary>
        /// Yön
        /// </summary>
        [Newtonsoft.Json.JsonProperty("direction", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Direction { get; set; }

        /// <summary>
        /// Toplam Kapasite(MW)
        /// </summary>
        [Newtonsoft.Json.JsonProperty("auctionCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string AuctionCode { get; set; }

        /// <summary>
        /// Transfer Zamanı
        /// </summary>
        [Newtonsoft.Json.JsonProperty("date", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? Date { get; set; }

        /// <summary>
        /// `2023-01-01T00:00:00+03:00` formatında tarih bilgisi.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("time", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? Time { get; set; }

        /// <summary>
        /// Toplam Kapasite(MW)
        /// </summary>
        [Newtonsoft.Json.JsonProperty("requestedCapacity", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? RequestedCapacity { get; set; }

        /// <summary>
        /// Toplam Kapasite(MW)
        /// </summary>
        [Newtonsoft.Json.JsonProperty("allocatedCapacity", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? AllocatedCapacity { get; set; }

        /// <summary>
        /// Toplam Kapasite(MW)
        /// </summary>
        [Newtonsoft.Json.JsonProperty("clearencePrice", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? ClearencePrice { get; set; }

        /// <summary>
        /// Toplam Kapasite(MW)
        /// </summary>
        [Newtonsoft.Json.JsonProperty("participantCount", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? ParticipantCount { get; set; }

        /// <summary>
        /// Toplam Kapasite(MW)
        /// </summary>
        [Newtonsoft.Json.JsonProperty("winnerCount", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? WinnerCount { get; set; }

        /// <summary>
        /// Toplam Kapasite(MW)
        /// </summary>
        [Newtonsoft.Json.JsonProperty("bidCount", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? BidCount { get; set; }

    }


}
