namespace EpiasElectricityMarketClient.Models
{

    public partial class PtfResponseStatisticsDto
    {
        [Newtonsoft.Json.JsonProperty("priceAvg", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? PriceAvg { get; set; }

        [Newtonsoft.Json.JsonProperty("priceUsdAvg", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? PriceUsdAvg { get; set; }

        [Newtonsoft.Json.JsonProperty("priceEurAvg", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? PriceEurAvg { get; set; }

        [Newtonsoft.Json.JsonProperty("priceMax", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? PriceMax { get; set; }

        [Newtonsoft.Json.JsonProperty("priceUsdMax", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? PriceUsdMax { get; set; }

        [Newtonsoft.Json.JsonProperty("priceEurMax", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? PriceEurMax { get; set; }

        [Newtonsoft.Json.JsonProperty("priceMin", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? PriceMin { get; set; }

        [Newtonsoft.Json.JsonProperty("priceUsdMin", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? PriceUsdMin { get; set; }

        [Newtonsoft.Json.JsonProperty("priceEurMin", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? PriceEurMin { get; set; }

        [Newtonsoft.Json.JsonProperty("priceTotal", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? PriceTotal { get; set; }

        [Newtonsoft.Json.JsonProperty("priceUsdTotal", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? PriceUsdTotal { get; set; }

        [Newtonsoft.Json.JsonProperty("priceEurTotal", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? PriceEurTotal { get; set; }

        [Newtonsoft.Json.JsonProperty("ptfWeightedAvg", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? PtfWeightedAvg { get; set; }

        [Newtonsoft.Json.JsonProperty("ptfUsdWeightedAvg", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? PtfUsdWeightedAvg { get; set; }

        [Newtonsoft.Json.JsonProperty("ptfEurWeightedAvg", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? PtfEurWeightedAvg { get; set; }

    }

}
