using Newtonsoft.Json;

namespace YTSDotNet
{
    public class Metadata
    {
        [JsonProperty(PropertyName = "server_time")]
        public string ServerTime;

        [JsonProperty(PropertyName = "server_timezone")]
        public string ServerTimezone;

        [JsonProperty(PropertyName = "api_version")]
        public int APIVersion;

        [JsonProperty(PropertyName = "execution_time")]
        public string ExecutionTime;
    }
}
