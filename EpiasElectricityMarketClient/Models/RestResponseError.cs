namespace EpiasElectricityMarketClient.Models
{
    public partial class RestResponseError
    {
        /// <summary>
        /// Error Code
        /// </summary>
        [Newtonsoft.Json.JsonProperty("errorCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// Error Message
        /// </summary>
        [Newtonsoft.Json.JsonProperty("errorMessage", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ErrorMessage { get; set; }

    }

}
