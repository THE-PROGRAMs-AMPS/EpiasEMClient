using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpiasElectricityMarketClient.Models
{
    public partial class YekgMinMaxMatchAmountStatisticsDto
    {
        [Newtonsoft.Json.JsonProperty("totalMinMatchPrice", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? TotalMinMatchPrice { get; set; }

        [Newtonsoft.Json.JsonProperty("totalMaxMatchPrice", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? TotalMaxMatchPrice { get; set; }

    }

}
