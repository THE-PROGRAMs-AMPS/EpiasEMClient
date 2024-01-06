using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpiasElectricityMarketClient.Models
{
    public partial class RenewablesParticipantExportRequestDto
    {
        /// <summary>
        /// Yıl Bilgisi
        /// </summary>
        [Newtonsoft.Json.JsonProperty("year", Required = Newtonsoft.Json.Required.Always)]
        public double Year { get; set; }

        /// <summary>
        /// Sayfalama bilgisi.
        /// </summary>
        [Newtonsoft.Json.JsonProperty("page", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Page Page { get; set; }

        /// <summary>
        /// XLSX, CSV ya da PDF
        /// </summary>
        [Newtonsoft.Json.JsonProperty("exportType", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public RenewablesParticipantExportRequestDtoExportType ExportType { get; set; }

    }
}
