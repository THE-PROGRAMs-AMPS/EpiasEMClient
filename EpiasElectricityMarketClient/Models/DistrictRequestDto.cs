namespace EpiasElectricityMarketClient.Models
{
    public partial class DistrictRequestDto
    {
        /// <summary>
        /// Şehir Id bilgisi(bkz.Şehir Listesi Getirme Servisi)
        /// </summary>
        [Newtonsoft.Json.JsonProperty("provinceId", Required = Newtonsoft.Json.Required.Always)]
        public int ProvinceId { get; set; }

    }
}
