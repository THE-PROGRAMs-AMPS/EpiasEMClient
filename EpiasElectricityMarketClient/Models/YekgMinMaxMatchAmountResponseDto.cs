﻿namespace EpiasElectricityMarketClient.Models
{
    public partial class YekgMinMaxMatchAmountResponseDto
    {
        [Newtonsoft.Json.JsonProperty("items", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<YekgMinMaxMatchAmountDataDto> Items { get; set; }

        [Newtonsoft.Json.JsonProperty("page", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Page Page { get; set; }

        [Newtonsoft.Json.JsonProperty("statistics", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public YekgMinMaxMatchAmountStatisticsDto Statistics { get; set; }

    }
}
