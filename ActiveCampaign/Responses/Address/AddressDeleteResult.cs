using Newtonsoft.Json;

namespace ActiveCampaign.Responses.Address
{
    public class AddressDeleteResult : IApiResult
    {
        [JsonProperty("success")]
        public int Success { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("result_code")]
        public int ResultCode { get; set; }

        [JsonProperty("result_message")]
        public string ResultMessage { get; set; }

        [JsonProperty("result_output")]
        public string ResultOutput { get; set; }
    }
}