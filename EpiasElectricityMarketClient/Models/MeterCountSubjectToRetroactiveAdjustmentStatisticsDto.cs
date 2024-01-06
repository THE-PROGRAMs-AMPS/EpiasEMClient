namespace EpiasElectricityMarketClient.Models
{
    public partial class MeterCountSubjectToRetroactiveAdjustmentStatisticsDto
    {
        [Newtonsoft.Json.JsonProperty("totalCountTotal", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? TotalCountTotal { get; set; }

        [Newtonsoft.Json.JsonProperty("threeTimedMeterCountTotal", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? ThreeTimedMeterCountTotal { get; set; }

        [Newtonsoft.Json.JsonProperty("singleTimedMeterCountTotal", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? SingleTimedMeterCountTotal { get; set; }

        [Newtonsoft.Json.JsonProperty("hourlyTimedMeterCountTotal", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? HourlyTimedMeterCountTotal { get; set; }

    }
}
