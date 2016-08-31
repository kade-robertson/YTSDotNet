using Newtonsoft.Json;

namespace YTSDotNet
{
    public class RequestResult<T> 
    {
        [JsonProperty(PropertyName = "status")]
        public string Status;

        [JsonProperty(PropertyName = "status_message")]
        public string StatusMessage;

        [JsonProperty(PropertyName = "data")]
        public T Data;

        [JsonProperty(PropertyName = "@meta")]
        public Metadata MetaInfo;
    }
}
