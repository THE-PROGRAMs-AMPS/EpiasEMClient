namespace EpiasElectricityMarketClient.Models
{
    public partial class KgupStatisticsDto
    {
        [Newtonsoft.Json.JsonProperty("toplamTotal", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? ToplamTotal { get; set; }

        [Newtonsoft.Json.JsonProperty("dogalgazTotal", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? DogalgazTotal { get; set; }

        [Newtonsoft.Json.JsonProperty("ruzgarTotal", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? RuzgarTotal { get; set; }

        [Newtonsoft.Json.JsonProperty("linyitTotal", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? LinyitTotal { get; set; }

        [Newtonsoft.Json.JsonProperty("tasKomurTotal", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? TasKomurTotal { get; set; }

        [Newtonsoft.Json.JsonProperty("ithalKomurTotal", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? IthalKomurTotal { get; set; }

        [Newtonsoft.Json.JsonProperty("fuelOilTotal", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? FuelOilTotal { get; set; }

        [Newtonsoft.Json.JsonProperty("jeotermalTotal", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? JeotermalTotal { get; set; }

        [Newtonsoft.Json.JsonProperty("barajliTotal", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? BarajliTotal { get; set; }

        [Newtonsoft.Json.JsonProperty("naftaTotal", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? NaftaTotal { get; set; }

        [Newtonsoft.Json.JsonProperty("biokutleTotal", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? BiokutleTotal { get; set; }

        [Newtonsoft.Json.JsonProperty("akarsuTotal", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? AkarsuTotal { get; set; }

        [Newtonsoft.Json.JsonProperty("digerTotal", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? DigerTotal { get; set; }

    }

}
