namespace EpiasElectricityMarketClient.Models
{

    public partial class RestResponseBooleanDTO
    {
        /// <summary>
        /// Status
        /// </summary>
        [Newtonsoft.Json.JsonProperty("status", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Status { get; set; }

        /// <summary>
        /// Transaction Id
        /// </summary>
        [Newtonsoft.Json.JsonProperty("correlationId", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string CorrelationId { get; set; }

        [Newtonsoft.Json.JsonProperty("spanIds", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string SpanIds { get; set; }

        [Newtonsoft.Json.JsonProperty("hostName", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string HostName { get; set; }

        /// <summary>
        /// Client Ip
        /// </summary>
        [Newtonsoft.Json.JsonProperty("clientIp", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ClientIp { get; set; }

        /// <summary>
        /// Username
        /// </summary>
        [Newtonsoft.Json.JsonProperty("userName", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string UserName { get; set; }

        [Newtonsoft.Json.JsonProperty("successMessage", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string SuccessMessage { get; set; }

        /// <summary>
        /// Error
        /// </summary>
        [Newtonsoft.Json.JsonProperty("errors", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<RestResponseError> Errors { get; set; }

        /// <summary>
        /// Unsuccessful List
        /// </summary>
        [Newtonsoft.Json.JsonProperty("unsuccessfulList", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<BaseDTO> UnsuccessfulList { get; set; }

        [Newtonsoft.Json.JsonProperty("dispatch", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Dispatch { get; set; }

        /// <summary>
        /// Rest Response Body
        /// </summary>
        [Newtonsoft.Json.JsonProperty("body", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public RestResponseBodyBooleanDTO Body { get; set; }

    }


}
