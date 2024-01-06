﻿namespace EpiasElectricityMarketClient.Models
{
    public partial class PriceIndependentOfferDataDto
    {
        /// <summary>
        /// `2023-01-01T00:00:00+03:00` formatında tarih bilgisi.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("date", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset? Date { get; set; }

        /// <summary>
        /// Saat Bilgisi
        /// </summary>
        [Newtonsoft.Json.JsonProperty("hour", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Hour { get; set; }

        /// <summary>
        /// Toplam Esnek Alış Teklif Miktarı (Mwh)
        /// </summary>
        [Newtonsoft.Json.JsonProperty("offerVolume", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? OfferVolume { get; set; }

    }
}
