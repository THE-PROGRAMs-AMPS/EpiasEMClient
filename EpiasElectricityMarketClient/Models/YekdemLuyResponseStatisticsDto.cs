namespace EpiasElectricityMarketClient.Models
{
    public partial class YekdemLuyResponseStatisticsDto
    {
        [Newtonsoft.Json.JsonProperty("toplam", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? Toplam { get; set; }

        [Newtonsoft.Json.JsonProperty("ruzgar", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? Ruzgar { get; set; }

        [Newtonsoft.Json.JsonProperty("biyogaz", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? Biyogaz { get; set; }

        [Newtonsoft.Json.JsonProperty("kanalTipi", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? KanalTipi { get; set; }

        [Newtonsoft.Json.JsonProperty("gunes", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? Gunes { get; set; }

        [Newtonsoft.Json.JsonProperty("biyokutle", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? Biyokutle { get; set; }

        [Newtonsoft.Json.JsonProperty("diger", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? Diger { get; set; }

    }
}
