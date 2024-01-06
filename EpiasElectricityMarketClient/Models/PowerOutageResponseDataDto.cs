namespace EpiasElectricityMarketClient.Models
{


    public partial class PowerOutageResponseDataDto
    {
        /// <summary>
        /// Şehir Id bilgisi(bkz.Şehir Listeleme Servisi)
        /// </summary>
        [Newtonsoft.Json.JsonProperty("province", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Province { get; set; }

        /// <summary>
        /// İlçe
        /// </summary>
        [Newtonsoft.Json.JsonProperty("district", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string District { get; set; }

        /// <summary>
        /// `2023-01-01T00:00:00+03:00` formatında tarih bilgisi.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("date", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? Date { get; set; }

        /// <summary>
        /// Dağıtım Şirketinin Adı
        /// </summary>
        [Newtonsoft.Json.JsonProperty("distributionCompanyName", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string DistributionCompanyName { get; set; }

        /// <summary>
        /// `2023-01-01T00:00:00+03:00` formatında tarih bilgisi.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("startTime", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? StartTime { get; set; }

        /// <summary>
        /// `2023-01-01T00:00:00+03:00` formatında tarih bilgisi.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("endTime", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? EndTime { get; set; }

        /// <summary>
        /// Kesinti Nedeni
        /// </summary>
        [Newtonsoft.Json.JsonProperty("reason", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Reason { get; set; }

        /// <summary>
        /// Etkilenen Bölgeler
        /// </summary>
        [Newtonsoft.Json.JsonProperty("effectedNeighbourhoods", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string EffectedNeighbourhoods { get; set; }

        /// <summary>
        /// Etkilenen Abone Sayısı
        /// </summary>
        [Newtonsoft.Json.JsonProperty("effectedSubscribers", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public long? EffectedSubscribers { get; set; }

        /// <summary>
        /// Saatlik Çekilen Yük Miktarı (KWh)
        /// </summary>
        [Newtonsoft.Json.JsonProperty("hourlyLoadAvg", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? HourlyLoadAvg { get; set; }

        /// <summary>
        /// Id
        /// </summary>
        [Newtonsoft.Json.JsonProperty("id", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public long? Id { get; set; }

    }


}
