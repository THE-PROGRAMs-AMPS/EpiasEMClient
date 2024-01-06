namespace EpiasElectricityMarketClient.Models
{

    public partial class UevcbRequestDto
    {
        /// <summary>
        /// `2023-01-01T00:00:00+03:00` formatında tarih bilgisi.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("startDate", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public System.DateTimeOffset StartDate { get; set; }

        /// <summary>
        /// Santral id değeri
        /// </summary>
        [Newtonsoft.Json.JsonProperty("powerPlantId", Required = Newtonsoft.Json.Required.Always)]
        public long PowerPlantId { get; set; }

    }
}
