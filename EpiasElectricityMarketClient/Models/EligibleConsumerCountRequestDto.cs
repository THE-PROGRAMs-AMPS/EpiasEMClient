﻿namespace EpiasElectricityMarketClient.Models
{
    public partial class EligibleConsumerCountRequestDto
    {
        /// <summary>
        /// `2023-01-01T00:00:00+03:00` formatında tarih bilgisi.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("period", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public System.DateTimeOffset Period { get; set; }

        /// <summary>
        /// Şehir Id bilgisi(bkz.Şehir Listesi Getirme Servisi)
        /// </summary>
        [Newtonsoft.Json.JsonProperty("provinceId", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? ProvinceId { get; set; }

        /// <summary>
        /// Profil Abone Grubu
        /// </summary>
        [Newtonsoft.Json.JsonProperty("profileGroupName", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ProfileGroupName { get; set; }

        /// <summary>
        /// İlçe Adı
        /// </summary>
        [Newtonsoft.Json.JsonProperty("districtName", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string DistrictName { get; set; }

        /// <summary>
        /// Sayfalama bilgisi.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("page", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Page Page { get; set; }

    }
}
