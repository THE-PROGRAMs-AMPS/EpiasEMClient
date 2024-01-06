namespace EpiasElectricityMarketClient.Models
{
    public partial class RenewableSmUnitCostDataDto
    {
        /// <summary>
        /// Dönem
        /// </summary>
        [Newtonsoft.Json.JsonProperty("period", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? Period { get; set; }

        /// <summary>
        /// Versiyon
        /// </summary>
        [Newtonsoft.Json.JsonProperty("version", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? Version { get; set; }

        /// <summary>
        /// Serbest Tüketiciler İçin Birim Fiyat (TL/MWh)
        /// </summary>
        [Newtonsoft.Json.JsonProperty("supplierUnitCost", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? SupplierUnitCost { get; set; }

        /// <summary>
        /// GTŞ-K1 Birim Fiyat (TL/MWh)
        /// </summary>
        [Newtonsoft.Json.JsonProperty("unitCost", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? UnitCost { get; set; }

    }
}
