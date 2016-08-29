using Newtonsoft.Json;

namespace YTSDotNet
{
    public class ListMovieResult
    {
        [JsonProperty(PropertyName = "status")]
        public string Status;

        [JsonProperty(PropertyName = "status_message")]
        public string StatusMessage;

        [JsonProperty(PropertyName = "data")]
        public ListMovieData Data;

        [JsonProperty(PropertyName = "@meta")]
        public Metadata MetaInfo;
    }
}
